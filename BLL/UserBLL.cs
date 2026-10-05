using DAL;
using LoanDesk.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class UserBLL
    {

        static public bool IsAdminExist() 
        {
            bool IsExist = false;
            IsExist = UserDAL.IsAdminExist();

            return IsExist;

        }
        static public bool CheckPassword(string Password)
        {
            if (string.IsNullOrWhiteSpace(Password))
                throw new Exception("Password must not be null or empty");
            if (Password.Length > 20 || Password.Length < 5)
                throw new Exception("Password must be between 5 and 20.");

            // one number or symbol :
            if (!(utilities.utilities.IsStringContainSymbol(Password) || utilities.utilities.IsDigit(Password)))
                throw new Exception("Password must has at least one number or symbol.");
            //one uppuercase letter :
            if (!utilities.utilities.IsStringContainUpper(Password))
                throw new Exception("Password must has at least one uppercase letter.");

            return true;
        }
        private static bool CheckUser(User user)
        {

            if (user == null)
                throw new ArgumentNullException("user");

            if (string.IsNullOrWhiteSpace(user.Username))
                throw new Exception("Username must not be null or empty");
            if (user.Username.Length > 15 || user.Username.Length < 5)
                throw new Exception("Username must be between 5 and 15.");
            

            if (user.Role != "Admin" && user.Role != "Staff")
                throw new Exception("Role must be Admin or Staff.");


            return true;
        }
        public static bool AddNewUser(User user, string Password)
        {
            bool IsAdded = false;
            if (CheckUser(user)&& CheckPassword(Password))
            {
                user.PasswordSalt = PasswordHasher.GenerateSalt();
                user.PasswordHash = PasswordHasher.HashPassword(Password, user.PasswordSalt);

                IsAdded = UserDAL.AddNewUser(user);
            }
            return IsAdded;
        }
        public static bool UpdateUser(User user)
        {
            bool IsUpdated = false;
            if(!CheckUser(user)) 
            {
                return IsUpdated;
            }

            IsUpdated=UserDAL.UpdateUser(user);

            return IsUpdated;
        }
        public static bool DeleteUser(User user)
        {
            if (user.ID == Sessions.CurrentUser.ID)
                throw new Exception("You can not delete loging account.");

            return UserDAL.DeleteUser(user);
        }
        public static bool UpdateUserPassword(int ID,string Username,string OldPassword,string NewPassword)
        {
            bool IsUpdated = false;

            if (!IsPasswordCorrect(Username, OldPassword))
                return IsUpdated;

            if (!CheckPassword(NewPassword))
                return IsUpdated;

            string NewPasswordSalt = PasswordHasher.GenerateSalt();
            string NewPasswordHash = PasswordHasher.HashPassword(NewPassword, NewPasswordSalt);
             IsUpdated=UserDAL.UpdateUserPassword(ID, NewPasswordHash, NewPasswordSalt);


            return IsUpdated;
        }
        public static bool Login(string Username,string Password)
        {
            if (string.IsNullOrWhiteSpace(Username))
                throw new Exception("Username must not be null or empty");

            if (string.IsNullOrWhiteSpace(Password))
                throw new Exception("Password must not be null or empty");

            bool IsValid = false;

            User user=new User();
            try
            {
                 user = UserDAL.Find(Username);
            }
            catch(Exception ex)
            {
                throw new Exception("Error in Database please contact the Admin." , ex);
            }

            if (user == null)
                return IsValid;

            else
            {
                //here we will compare the password with the PasswordHash and PasswordSalt:
                IsValid = PasswordHasher.VerifyPassword(Password, user.PasswordSalt, user.PasswordHash);
              if(IsValid )
                    {
                    if (user.IsActive == false)
                        {
                                IsValid = false;
                        return IsValid;
                                    }
                    Sessions.CreateUserSession(user.ID, user.Username, user.Role, user.IsActive); 
                }
            }
              
            

            return IsValid;
        }
        public static bool IsPasswordCorrect(string Username, string Password) 
        {
            if (string.IsNullOrWhiteSpace(Username))
                throw new Exception("Username must not be null or empty");


            bool IsValid = false;

            User user = new User();
            try
            {
                user = UserDAL.Find(Username);
            }
            catch (Exception ex)
            {
                throw new Exception("Error in Database please contact the Admin.", ex);
            }

            if (user == null)
                return IsValid;

            else
            {
                //here we will compare the password with the PasswordHash and PasswordSalt:
                IsValid = PasswordHasher.VerifyPassword(Password, user.PasswordSalt, user.PasswordHash);
           
            }



            return IsValid;
        }
       public static DataTable GetUsers() 
        {

            return UserDAL.GetUsers();
            
        }
    }
}
