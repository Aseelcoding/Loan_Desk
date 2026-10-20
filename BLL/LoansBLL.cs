using DAL;
using LoanDesk.Models;
using System;
using System.Data;
using System.Collections.Generic;

namespace BLL
{
    public class LoansBLL
    {
        private static void LoanDefaultData(Loan Loan)
        {
            Loan.LoanedAt = DateTime.Now;
            Loan.DueAt = DateTime.Now.AddDays(3);
            Loan.Status = "Active";
            Loan.LateFee = 0;
            Loan.LostQuantity = 0;
            Loan.ReplacementFee = 0;
            Loan.ReplacementPaid = null;
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

            return dtLoans;
        }

        public static void GetFinalLateFee(Loan loan) 
        {
            if(loan.ReturnedAt !=null&& Math.Max(0, (loan.ReturnedAt.Value.Date - loan.DueAt.Date).Days)==0) 
            {
                loan.LateFee = 0;
                return;
            }



            int daysLate = Math.Max(0, (DateTime.Today - loan.DueAt.Date).Days);

            Equipment equipment = EquipmentBLL.GetEquipmentByID(loan.EquipmentID);

            if (equipment == null)
                throw new Exceptions.ValidationException("Equipment not found.");

            
            decimal lateFee = equipment.DailyLateFee * daysLate;

            loan.LateFee = lateFee;

            if (lateFee > 0 && loan.FinePaid == null)
                loan.FinePaid = false;

            
        }
        public static decimal CalculateReplacementFee(Loan loan, int lostQuantity)
        {
            if (loan == null)
                throw new Exceptions.ValidationException("Please choose a valid loan.");

            if (loan.Status != "Lost")
                throw new Exceptions.BusinessRuleException("Replacement fees can only be calculated for a lost loan.");

            if (lostQuantity < 1 || lostQuantity > loan.Quantity)
                throw new Exceptions.ValidationException("Lost quantity must be between 1 and the loan quantity.");

            Equipment equipment = EquipmentBLL.GetEquipmentByID(loan.EquipmentID);
            if (equipment == null)
                throw new Exceptions.ValidationException("Equipment not found.");

            loan.LostQuantity = lostQuantity;
            loan.ReplacementFee = equipment.ReplacementCost * lostQuantity;
            loan.ReplacementPaid = loan.ReplacementFee > 0 ? (bool?)false : null;
            return loan.ReplacementFee;
        }

        public static bool PayFine(Loan loan)
        {
            UserBLL.RequireUser();

            if (loan == null)
                throw new Exceptions.ValidationException("Please choose a valid loan.");

            if (loan.Status != "Returned" && loan.Status != "Lost")
                throw new Exceptions.BusinessRuleException("Return or mark the equipment as lost before taking payment.");

            bool hasUnpaidLateFee = loan.LateFee > 0 && loan.FinePaid != true;
            bool hasUnpaidReplacementFee = loan.ReplacementFee > 0 && loan.ReplacementPaid != true;

            if (!hasUnpaidLateFee && !hasUnpaidReplacementFee)
                throw new Exceptions.ValidationException("There are no unpaid fees for this loan.");

            if (loan.LateFee > 0)
                loan.FinePaid = true;

            if (loan.ReplacementFee > 0)
                loan.ReplacementPaid = true;

            return UpdateLoan(loan);
        }

        public static bool AddLoan(LoanDesk.Models.Loan NewLoan)
        {
            UserBLL.RequireUser();
            LoanDefaultData(NewLoan);
            ValidateLoan(NewLoan);
            LoanDefaultData(NewLoan);
            return LoansDAL.AddLoan(NewLoan);
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
            //here we will set the correct data of equipment and send it with tha loan to update them togather using transaction
            Equipment equipment = EquipmentBLL.GetEquipmentByID(ReturnedLoan.EquipmentID);
            equipment.AvailableQuantity += ReturnedLoan.Quantity;
            //here we will set the correct data of loan 
            ReturnedLoan.ReturnedAt = DateTime.Now;
            ReturnedLoan.Status = "Returned";


            return LoansDAL.ReturnEquipment(ReturnedLoan, equipment);


        }

    }
}