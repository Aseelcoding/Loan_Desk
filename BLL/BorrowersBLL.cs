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
         //catch (Exception ex) 
         //   {
         //       if (!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException))
         //       {
         //           Logger.Write(ex);
         //       }

         //       throw;
         //   }

        private static void ValidateBorrower(Borrower Newborrower) 
        {
            utilities.utilities.IsEmptyOrNullOrWhiteSpace(Newborrower.FullName, "Full Name");
            utilities.utilities.ValidateLength(Newborrower.FullName, "Full Name", 3, 250);
            utilities.utilities.ValidateName(Newborrower.FullName);
            utilities.utilities.IsEmptyOrNullOrWhiteSpace(Newborrower.Passport, "Passport");
            utilities.utilities.ValidateLength(Newborrower.Passport, "Passport", 6, 30);
            if (!utilities.utilities.IsStringContainSymbol(Newborrower.Passport)) 
            {
                throw new Exceptions.ValidationException("Passport must has only chars and numbers");
            }
            utilities.utilities.IsEmptyOrNullOrWhiteSpace(Newborrower.Phone, "Phone Number");
            utilities.utilities.ValidateLength(Newborrower.Phone, "Phone Number", 9, 25);

            Newborrower.Phone= utilities.utilities.SanitizePhoneNumber(Newborrower.Phone);

            utilities.utilities.IsValidPhoneNumber(Newborrower.Phone);
          

           

            
        }
        public static DataTable GetBorrowers() 
        {
            try
            {
                return BorrowersDAL.GetBorrowers();
            }
            catch (Exception ex)
            {
                if (!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException))
                {
                    Logger.Write(ex);
                }

                throw;
            }

        }
        public static bool AddNewBorrower(Borrower Newborrower) 
        {
            bool IsAdded = false;
            try
            {
                ValidateBorrower(Newborrower);

                Borrower _borrower1 = GetBorrowerByPassport(Newborrower.Passport);
                if (_borrower1 != null && _borrower1.ID != Newborrower.ID)
                    throw new Exceptions.BusinessRuleException("Passport must be unique");

                IsAdded = BorrowersDAL.AddNewBorrower(Newborrower);
            }
            catch (Exception ex) 
            {
                if (!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException))
                {
                    Logger.Write(ex);
                }

                throw;
            }

            return IsAdded;
        }
        public static Borrower GetBorrowerByID(int BorrowerID) 
        {
            try
            {
                return BorrowersDAL.GetBorrowerByID(BorrowerID);

            }
            catch (Exception ex)
            {
                if (!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException))
                {
                    Logger.Write(ex);
                }

                throw;
            }
        }
        public static Borrower GetBorrowerByPassport(string Passport)
        {
            try
            {
                return BorrowersDAL.GetBorrowerByPassport(Passport);

            }
            catch (Exception ex)
            {
                if (!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException))
                {
                    Logger.Write(ex);
                }

                throw;
            }
        }
        public static bool UpdateBorrower(Borrower borrower) 
        {
            bool IsUpdated = false;
            try
            {
                ValidateBorrower(borrower);

                Borrower _borrower1=GetBorrowerByPassport(borrower.Passport);
                if (_borrower1 != null && _borrower1.ID != borrower.ID)
                    throw new Exceptions.BusinessRuleException("Passport must be unique");

                IsUpdated = BorrowersDAL.UpdateBorrower(borrower);
            }
            catch (Exception ex)
            {
                if (!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException))
                {
                    Logger.Write(ex);
                }

                throw;
            }

            return IsUpdated;
        }
        public static bool DeactivateBorrowerByID(int BorrowerID) 
        {
            bool IsDeactivate = false;

            try 
            {
                

                IsDeactivate = BorrowersDAL.DeactivateBorrowerByID(BorrowerID);

            }
            catch (Exception ex) 
            {

                if(!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException)) 
                {
                    Logger.Write(ex);
                }
                throw;
            }
            return IsDeactivate;
        }
        public static bool ActivateBorrowerByID(int BorrowerID) 
        {
            bool IsActivated = false;

            try
            {
                IsActivated = BorrowersDAL.ActivateBorrowerByID(BorrowerID);

            }
            catch (Exception ex)
            {

                if (!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException))
                {
                    Logger.Write(ex);
                }
                throw;
            }
            return IsActivated;
        }
    }
}
