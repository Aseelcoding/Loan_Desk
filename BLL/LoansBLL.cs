using DAL;
using LoanDesk.Models;
using System;
using System.Data;
using System.Collections.Generic;

namespace BLL
{
    public class LoansBLL
    {
        
        private enum eActions { Add, Return, PayFine, MarkLost };
        static eActions Actions { get; set; }
        private static readonly string EntityType = "Loans";
        private static void LoanDefaultData(Loan Loan)
        {
            Loan.LoanedAt = DateTime.Now;
            Loan.DueAt = DateTime.Now.AddDays(3);
            Loan.Status = "Active";
            Loan.LateFee = 0;
        }

        private static void ValidateLoan(Loan Loan)
        {
            //Borrower , user and equipment must be active to make a loan

            //user :
            if (!UserDAL.IsActive(Loan.UserID))
                throw new Exceptions.BusinessRuleException("Current user is not active or logeed out");
            //Borrower :
            if (!BorrowersDAL.IsActive(Loan.BorrowerID))
                throw new Exceptions.BusinessRuleException($"Current borrower with the id {Loan.BorrowerID} is not active");
            if (BorrowersDAL.GetActiveLoansCountByBorrowerID(Loan.BorrowerID) >= 3)
                throw new Exceptions.BusinessRuleException("A borrower can not has more than 3 active loans.");
            if (LoansDAL.hasUnpaidfee(Loan.BorrowerID))
                throw new Exceptions.BusinessRuleException("A borrower who has Unpaid fine can not get new loan");
            //Equipment :
            Equipment equipment = EquipmentDAL.GetEquipmentByID(Loan.EquipmentID);
            if (equipment != null)
            {
                if (!equipment.IsActive)
                    throw new Exceptions.BusinessRuleException("Current equipment is not active");

                if (Loan.Quantity <= 0)
                    throw new Exceptions.BusinessRuleException("Quantity must be at least one");

                if (equipment.AvailableQuantity == 0)
                    throw new Exceptions.BusinessRuleException($"Current Available quantity is {equipment.AvailableQuantity}, there is no available equipments.");
                if (equipment.AvailableQuantity < Loan.Quantity)
                    throw new Exceptions.BusinessRuleException($"Current Available quantity is {equipment.AvailableQuantity}, you can not take more than that");

                if (Loan.Quantity > 3)
                    throw new Exceptions.BusinessRuleException("A borrower can take a maximum of 3 items each loan");
            }
            else
                throw new Exceptions.ValidationException($"there is no Equipment with this ID {Loan.EquipmentID}");
        }

        public static DataTable GetAllLoans()
        {
            UserBLL.RequireUser();
            return CalculateLateFee(LoansDAL.GetAllLoans());
        }
        private static DataTable CalculateLateFee(DataTable dtLoans)
        {


            List<Equipment> equipments = EquipmentBLL.GetEquipmentList();

            foreach (DataRow row in dtLoans.Rows)
            {

                if (row["Status"].ToString() != "Returned" && row["Status"].ToString() != "Lost")
                {
                    DateTime.TryParse(row["DueAt"].ToString(), out DateTime dueAt);
                    int daysLate = Math.Max(0, (DateTime.Today - dueAt.Date).Days);

                    if (daysLate <= 0)
                    {
                        row["LateFee"] = 0m;
                        continue;
                    }

                    int.TryParse(row["EquipmentID"].ToString(), out int eqID);

                    Equipment equipment = equipments.Find(item => item.ID == eqID);

                    if (equipment == null)
                        continue;

                    decimal lateFee = equipment.DailyLateFee * daysLate;

                    row["LateFee"] = lateFee;
                    if (lateFee > 0 && row["FinePaid"] == DBNull.Value)
                    {
                        row["FinePaid"] = false;
                    }
                }
            }

            return dtLoans;
        }

        public static void GetFinalLateFee(Loan loan) 
        {
            Equipment equipment =
        EquipmentBLL.GetEquipmentByID(loan.EquipmentID);

            if (equipment == null)
                throw new Exceptions.ValidationException("Equipment not found.");

            DateTime calculationDate =
                loan.ReturnedAt?.Date ?? DateTime.Today;

            int daysLate = Math.Max(
                0,
                (calculationDate - loan.DueAt.Date).Days
            );

            decimal lateFee = equipment.DailyLateFee * daysLate;

            loan.LateFee = lateFee;

            if (lateFee > 0 && loan.FinePaid == null)
                loan.FinePaid = false;


        }
        public static bool PayFine(Loan loan)
        {

            bool IsFinePaid = false;
            UserBLL.RequireUser();
      

            decimal totalDue = loan.LateFee + loan.ReplacementFee;

            if (totalDue <= 0)
                throw new Exceptions.ValidationException($"There is no fee due for loan with the ID :{loan.ID}");
            if (loan.Status == "Active")
                throw new Exceptions.BusinessRuleException("Please first return the equipment\nafter that you can pay the fine.");
            if (loan.FinePaid == true)
                throw new Exceptions.BusinessRuleException("This loan is already paid.");
            loan.FinePaid = true;
            IsFinePaid= UpdateLoan(loan);
            if (IsFinePaid) 
            {
                AuditLog auditLog = new AuditLog();
                auditLog.UserID = Sessions.CurrentUser.ID;
                auditLog.ActionDate = DateTime.Now;
                Actions = eActions.PayFine;
                auditLog.Action = Actions.ToString();
                auditLog.EntityType = EntityType;
                auditLog.EntityID = loan.ID;
                auditLog.Details = "Pay Loan Fine.";
                AuditLogBLL.AddNewAuditLog(auditLog);
            }
            return IsFinePaid;
        }
        public static bool AddLoan(LoanDesk.Models.Loan NewLoan)
        {
            bool IsAdded = false;
            UserBLL.RequireUser();
            LoanDefaultData(NewLoan);
            ValidateLoan(NewLoan);
            LoanDefaultData(NewLoan);
            IsAdded= LoansDAL.AddLoan(NewLoan);

            if (IsAdded) 
            {
                AuditLog auditLog = new AuditLog();
                auditLog.UserID = Sessions.CurrentUser.ID;
                auditLog.ActionDate = DateTime.Now;
                Actions = eActions.Add;
                auditLog.Action = Actions.ToString();
                auditLog.EntityType = EntityType;
                auditLog.EntityID = NewLoan.ID;
                auditLog.Details = "Add New Loan.";
                AuditLogBLL.AddNewAuditLog(auditLog);
            }
            return IsAdded;
        }

        private static bool UpdateLoan(Loan loan) 
        {
            
            return LoansDAL.UpdateLoan(loan);
        }

        public static DataTable GetDailyLoanStatistics(
DateTime StartDate,
DateTime EndDate)
        {
            return LoansDAL.GetDailyLoanStatistics(StartDate, EndDate);
        }
        public static bool ReturnEquipment(Loan ReturnedLoan) 
        {
            //first we will check if the current user is active or not
            UserBLL.RequireUser();
            if (ReturnedLoan.Status != "Active")
                throw new Exceptions.BusinessRuleException("This loan has been returned.");
            //here we will set the correct data of equipment and send it with tha loan to update them togather using transaction
            Equipment equipment = EquipmentBLL.GetEquipmentByID(ReturnedLoan.EquipmentID);
            equipment.AvailableQuantity += ReturnedLoan.Quantity;
            //here we will set the correct data of loan 
            ReturnedLoan.ReturnedAt = DateTime.Now;
            ReturnedLoan.Status = "Returned";

            GetFinalLateFee(ReturnedLoan);
            bool IsReturned = false;
            IsReturned= LoansDAL.ReturnEquipment(ReturnedLoan, equipment);

            if (IsReturned) 
            {
                AuditLog auditLog = new AuditLog();
                auditLog.UserID = Sessions.CurrentUser.ID;
                auditLog.ActionDate = DateTime.Now;
                Actions = eActions.Return;
                auditLog.Action = Actions.ToString();
                auditLog.EntityType = EntityType;
                auditLog.EntityID = ReturnedLoan.ID;
                auditLog.Details = "Return Loan.";
                AuditLogBLL.AddNewAuditLog(auditLog);

            }
            return IsReturned;
        }
        public static void CalculateReplacementFee(Loan Loan) 
        {
            Equipment equipment = EquipmentBLL.GetEquipmentByID(Loan.EquipmentID);
            Loan.ReplacementFee = equipment.ReplacementCost * Loan.Quantity;

         

        }

        public static bool MarkLoanLost(Loan Loan) 
        {
            UserBLL.RequireUser();

            if (Loan.Status != "Active")
                throw new Exceptions.BusinessRuleException("Only an active loan can be marked as lost.");

            Loan.Status = "Lost";
            GetFinalLateFee(Loan);          
            CalculateReplacementFee(Loan);  
            Loan.FinePaid = false;         

            bool IsUpdated = LoansDAL.MarkLoanLost(Loan);  

            if (IsUpdated)
            {
                AuditLog auditLog = new AuditLog();
                auditLog.UserID = Sessions.CurrentUser.ID;
                auditLog.ActionDate = DateTime.Now;
                Actions = eActions.MarkLost;
                auditLog.Action = Actions.ToString();
                auditLog.EntityType = EntityType;
                auditLog.EntityID = Loan.ID;
                auditLog.Details = "Mark as lost.";
                AuditLogBLL.AddNewAuditLog(auditLog);
            }
            return IsUpdated;
        }

    }
}