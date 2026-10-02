using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoanDesk.Models;

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
            if (CheckUser(user))
            {
                user.PasswordSalt = PasswordHasher.GenerateSalt();
                user.PasswordHash = PasswordHasher.HashPassword(Password, user.PasswordSalt);

                IsAdded = UserDAL.AddNewUser(user);
            }
            return IsAdded;
        }
        public static bool Login(string Username,string Password)
        {
            if (string.IsNullOrWhiteSpace(Username))
                throw new Exception("Username must not be null or empty");
            if (Username.Length > 15 || Username.Length < 5)
                throw new Exception("Username must be between 5 and 15.");

            if (string.IsNullOrWhiteSpace(Password))
                throw new Exception("Password must not be null or empty");
            if (Password.Length > 20 || Password.Length < 5)
                throw new Exception("Password must be between 5 and 20.");

            bool IsValid = false;

            User user=new User();
            try
            {
                 user = UserDAL.Find(Username);
            }
            catch(Exception ex)
            {
                throw new Exception("Error in Database please contact the Admin. \n\nDetails:" + ex.Message);
            }

            if(user == null)
                return IsValid;
            else
            {
                //here we will compare the password with the PasswordHash and PasswordSalt:
                IsValid= PasswordHasher.VerifyPassword(Password, user.PasswordSalt,user.PasswordHash);

            }


            return IsValid;
        }
    }
}
