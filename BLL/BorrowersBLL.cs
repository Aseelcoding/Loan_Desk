using DAL;
using LoanDesk.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class BorrowersBLL
    {
        private enum eActions { Add, Update, Activate, Deactivate };
        static eActions Actions { get; set;}
        private static readonly string EntityType = "Borrowers";
        private static void EnsurePassportUnique(Borrower borrower)
        {
            Borrower existing = BorrowersDAL.GetBorrowerByPassport(borrower.Passport);
            if (existing != null && existing.ID != borrower.ID)
                throw new Exceptions.BusinessRuleException("Passport must be unique");
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
            UserBLL.RequireUser();
            return BorrowersDAL.GetBorrowers();
        }

        public static List<Borrower> GetAllBorrowersList()
        {
            return BorrowersDAL.GetAllBorrowersList();
        }

        public static bool AddNewBorrower(Borrower Newborrower)
        {

            UserBLL.RequireUser();
            ValidateBorrower(Newborrower);

            EnsurePassportUnique(Newborrower);

            bool IsAdded = false;
            IsAdded= BorrowersDAL.AddNewBorrower(Newborrower);

            if (IsAdded) 
            {
                AuditLog auditLog = new AuditLog();
                auditLog.UserID = Sessions.CurrentUser.ID;
                auditLog.ActionDate = DateTime.Now;
                Actions = eActions.Add;
                auditLog.Action = Actions.ToString();
                auditLog.EntityType = EntityType;
                auditLog.EntityID = Newborrower.ID;
                auditLog.Details = "Add new borrower.";
                AuditLogBLL.AddNewAuditLog(auditLog);
            }
            return IsAdded;
        }

        public static Borrower GetBorrowerByID(int BorrowerID)
        {
            UserBLL.RequireUser();
            return BorrowersDAL.GetBorrowerByID(BorrowerID);
        }

        public static Borrower GetBorrowerByPassport(string Passport)
        {
            UserBLL.RequireUser();
            return BorrowersDAL.GetBorrowerByPassport(Passport);
        }

        public static bool UpdateBorrower(Borrower borrower)
        {
            UserBLL.RequireUser();
            ValidateBorrower(borrower);

            EnsurePassportUnique(borrower);
            bool IsUpdated = false;
            IsUpdated= BorrowersDAL.UpdateBorrower(borrower);
            if (IsUpdated)
            {
                AuditLog auditLog = new AuditLog();
                auditLog.UserID = Sessions.CurrentUser.ID;
                auditLog.ActionDate = DateTime.Now;
                Actions = eActions.Update;
                auditLog.Action = Actions.ToString();
                auditLog.EntityType = EntityType;
                auditLog.EntityID = borrower.ID;
                auditLog.Details = "Update borrower.";
                AuditLogBLL.AddNewAuditLog(auditLog);

            }
            return IsUpdated;
        }

        public static bool DeactivateBorrowerByID(int BorrowerID)
        {
            UserBLL.RequireUser();
            if (BorrowersDAL.GetActiveLoansCountByBorrowerID(BorrowerID) >= 1)
                throw new Exceptions.BusinessRuleException($"This borrower with the ID {BorrowerID} has active loans.\nDeactivate loans first.");

            bool IsDeactivated = false;
            IsDeactivated= BorrowersDAL.DeactivateBorrowerByID(BorrowerID);

            if (IsDeactivated)
            {
                AuditLog auditLog = new AuditLog();
                auditLog.UserID = Sessions.CurrentUser.ID;
                auditLog.ActionDate = DateTime.Now;
                Actions = eActions.Deactivate;
                auditLog.Action = Actions.ToString();
                auditLog.EntityType = EntityType;
                auditLog.EntityID = BorrowerID;
                auditLog.Details = "Deactivate borrower.";
                AuditLogBLL.AddNewAuditLog(auditLog);
            }
            return IsDeactivated;
        }

        public static bool ActivateBorrowerByID(int BorrowerID)
        {
            UserBLL.RequireUser();
            bool IsActivated= BorrowersDAL.ActivateBorrowerByID(BorrowerID);

            if (IsActivated)
            {
                AuditLog auditLog = new AuditLog();
                auditLog.UserID = Sessions.CurrentUser.ID;
                auditLog.ActionDate = DateTime.Now;
                Actions = eActions.Activate;
                auditLog.Action = Actions.ToString();
                auditLog.EntityType = EntityType;
                auditLog.EntityID = BorrowerID;
                auditLog.Details = "Activate borrower.";
                AuditLogBLL.AddNewAuditLog(auditLog);
            }
            return IsActivated;
        }

        public static bool IsActive(int ID)
        {
            return BorrowersDAL.IsActive(ID);
        }
    }
}