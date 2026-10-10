using DAL;
using Loan_Desk;
using LoanDesk.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilities;

namespace BLL
{
    public class BorrowersBLL
    {
        private static void EnsurePassportUnique(Borrower borrower)
        {
            Borrower existing = BorrowersDAL.GetBorrowerByPassport(borrower.Passport);
            if (existing != null && existing.ID != borrower.ID)
                throw new Exceptions.BusinessRuleException("Passport must be unique");
        }

        private static void RequireUser()
        {
            if (Sessions.CurrentUser == null || Sessions.CurrentUser.IsActive == false)
                throw new Exceptions.BusinessRuleException("Please log in first");
        }

        private static void ValidateBorrower(Borrower Newborrower)
        {
            Newborrower.FullName = Newborrower.FullName?.Trim();
            Newborrower.Passport = Newborrower.Passport?.Trim().ToUpper();
            utilities.utilities.IsEmptyOrNullOrWhiteSpace(Newborrower.FullName, "Full Name");
            utilities.utilities.ValidateLength(Newborrower.FullName, "Full Name", 3, 250);
            utilities.utilities.ValidateName(Newborrower.FullName);
            utilities.utilities.IsEmptyOrNullOrWhiteSpace(Newborrower.Passport, "Passport");
            utilities.utilities.ValidateLength(Newborrower.Passport, "Passport", 6, 30);
            if (!System.Text.RegularExpressions.Regex.IsMatch(Newborrower.Passport, @"^[A-Z0-9]+$"))
                throw new Exceptions.ValidationException("Passport must contain only letters and numbers");
            utilities.utilities.IsEmptyOrNullOrWhiteSpace(Newborrower.Phone, "Phone Number");
            utilities.utilities.ValidateLength(Newborrower.Phone, "Phone Number", 9, 25);

            Newborrower.Phone = utilities.utilities.SanitizePhoneNumber(Newborrower.Phone);

            utilities.utilities.IsValidPhoneNumber(Newborrower.Phone);
        }

        public static DataTable GetBorrowers()
        {
            RequireUser();
            return BorrowersDAL.GetBorrowers();
        }

        public static bool AddNewBorrower(Borrower Newborrower)
        {
            RequireUser();
            ValidateBorrower(Newborrower);

            EnsurePassportUnique(Newborrower);

            return BorrowersDAL.AddNewBorrower(Newborrower);
        }

        public static Borrower GetBorrowerByID(int BorrowerID)
        {
            RequireUser();
            return BorrowersDAL.GetBorrowerByID(BorrowerID);
        }

        public static Borrower GetBorrowerByPassport(string Passport)
        {
            RequireUser();
            return BorrowersDAL.GetBorrowerByPassport(Passport);
        }

        public static bool UpdateBorrower(Borrower borrower)
        {
            RequireUser();
            ValidateBorrower(borrower);

            EnsurePassportUnique(borrower);

            return BorrowersDAL.UpdateBorrower(borrower);
        }

        public static bool DeactivateBorrowerByID(int BorrowerID)
        {
            RequireUser();

            return BorrowersDAL.DeactivateBorrowerByID(BorrowerID);
        }

        public static bool ActivateBorrowerByID(int BorrowerID)
        {
            RequireUser();
            return BorrowersDAL.ActivateBorrowerByID(BorrowerID);
        }
    }
}