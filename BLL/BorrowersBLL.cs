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
            utilities.utilities.IsValidName(Newborrower.FullName);
            utilities.utilities.IsEmptyOrNullOrWhiteSpace(Newborrower.Phone, "Phone Number");
            utilities.utilities.ValidateLength(Newborrower.Phone, "Phone Number", 9, 25);
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

    }
}
