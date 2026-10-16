using DAL;
using LoanDesk.Models;
using System;
using System.Data;

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
        }

        private static void ValidateLoan(Loan Loan)
        {
            //Borrower , user and equipment must be active to make a loan

            //user :
            if (!UserDAL.IsActive(Loan.UserID))
                throw new Exceptions.BusinessRuleException("Current user is not active or loged in");
            //Borrower :
            if (!BorrowersDAL.IsActive(Loan.BorrowerID))
                throw new Exceptions.BusinessRuleException($"Current borrower with the id {Loan.BorrowerID} is not active");
            if (BorrowersDAL.GetActiveLoansCountByBorrowerID(Loan.BorrowerID) >= 3)
                throw new Exceptions.BusinessRuleException("A borrower can not has more than 3 active loans.");
            if (LoansDAL.GetLateFee(Loan.BorrowerID) > 0)
                throw new Exceptions.BusinessRuleException("A borrower who has late fee can not get new loan");
            //Equipment :
            Equipment equipment = EquipmentDAL.GetEquipmentByID(Loan.EquipmentID);
            if (equipment != null)
            {
                if (!equipment.IsActive)
                    throw new Exceptions.BusinessRuleException("Current equipment is not active");

                if (Loan.Quantity <= 0)
                    throw new Exceptions.BusinessRuleException("Quantity must be at least one");
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
            return LoansDAL.GetAllLoans();
        }

        public static bool AddLoan(LoanDesk.Models.Loan NewLoan)
        {



            LoanDefaultData(NewLoan);
            ValidateLoan(NewLoan);
            LoanDefaultData(NewLoan);
            return LoansDAL.AddLoan(NewLoan);

        }
    }
}