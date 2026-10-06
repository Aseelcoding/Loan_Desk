using DAL;
using LoanDesk.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static LoanDesk.Models.Exceptions;
namespace BLL
{
    public class UserBLL
    {
        static public bool NeedToRestart = false; 
        static private bool RequireAdmin() 
        {
            if (Sessions.CurrentUser.Role == "Admin")
                return true;
            else 
                return false;
        }
        static public int CountActiveAdmins() 
        {
            return UserDAL.CountActiveAdmins();
        }
        static public int CountActiveUsers()
        {
            return UserDAL.CountActiveUsers();
        }
        static public bool IsAdminExist() 
        {
            bool IsExist = false;
            IsExist = UserDAL.IsAdminExist();

            return IsExist;

        }
        static public bool CheckPassword(string Password)
        {
            if (string.IsNullOrWhiteSpace(Password))
                throw new ValidationException("Password must not be null or empty");
            if (Password.Length > 20 || Password.Length < 5)
                throw new ValidationException("Password must be between 5 and 20.");

            // one number or symbol :
            if (!(utilities.utilities.IsStringContainSymbol(Password) || utilities.utilities.IsDigit(Password)))
                throw new ValidationException("Password must has at least one number or symbol.");
            //one uppuercase letter :
            if (!utilities.utilities.IsStringContainUpper(Password))
                throw new ValidationException("Password must has at least one uppercase letter.");

            return true;
        }
        private static bool CheckUser(User user)
        {

            if (user == null)
                throw new ArgumentNullException("user");

            if (string.IsNullOrWhiteSpace(user.Username))
               throw new ValidationException("Username must not be null or empty");

            if (user.Username.Length > 15 || user.Username.Length < 5)
                throw new ValidationException("Username must be between 5 and 15.");

             if( utilities.utilities.IsStringContainSymbol( user.Username))
                throw new ValidationException("Username must not has any Symbol.");

            if (user.Role != "Admin" && user.Role != "Staff")
                throw new ValidationException("Role must be Admin or Staff.");


            return true;
        }
        public static bool AddNewUser(User user, string Password)
        {
            if (!RequireAdmin())
                throw new BusinessRuleException("Only admins can add users");



            bool IsAdded = false;
            if (CheckUser(user)&& CheckPassword(Password))
            {
                if(UserDAL.Find(user.Username)==null)
                {user.PasswordSalt = PasswordHasher.GenerateSalt();
                user.PasswordHash = PasswordHasher.HashPassword(Password, user.PasswordSalt);

                    IsAdded = UserDAL.AddNewUser(user);
                }
                else
                {
                    throw new BusinessRuleException("duplicate username , please enter a uniqeu username.");
                }
            }


            return IsAdded;
        }
        public static bool UpdateUser(User user)
        {
            if (!RequireAdmin())
                throw new BusinessRuleException("Only admins can update users");

            bool IsUpdated = false;
            if(!CheckUser(user)) 
            {
                return IsUpdated;
            }

            LoanDesk.Models.User user2 = UserDAL.Find(user.Username);

            if(user2 != null)
            { 
                if (user2.ID != user.ID)
                    throw new BusinessRuleException($"Username '{user.Username}' is already taken. Please choose another one.");

            }

           
           

            if (Sessions.CurrentUser.ID == user.ID)
            {
                if (Sessions.CurrentUser.Role != user.Role)
                {
                    if (CountActiveAdmins() <= 1)
                        throw new BusinessRuleException("This is the only admin in the system you can not change his role to staff.");
                    else
                    {
                        //Sessions.CurrentUser = null;
                    NeedToRestart = true;
                        IsUpdated = UserDAL.UpdateUser(user);
                        return IsUpdated;
                    }



                }

                    Sessions.CreateUserSession(user.ID,user.Username,user.Role,user.IsActive);
            }
            else
            {
                IsUpdated = UserDAL.UpdateUser(user);
                if(IsUpdated)
                {
                    Sessions.CreateUserSession(user.ID, user.Username, user.Role, user.IsActive);
                }
            }

                return IsUpdated;
        }
        public static bool DeleteUser(User user)
        {
            if (!RequireAdmin())
                throw new BusinessRuleException("Only admins can delete users");

            if (user.ID == Sessions.CurrentUser.ID)
                throw new BusinessRuleException("You can not delete loging account.");

            return UserDAL.DeleteUser(user);
        }
        public static bool ActivateUser(int ID)
        {
            if (!RequireAdmin())
                throw new BusinessRuleException("Only admins can activate users");
            return UserDAL.ActivateUser(ID);

        }
        public static bool UpdateUserPassword(int ID,string Username,string OldPassword,string NewPassword)
        {
            bool IsUpdated = false;

            if (!RequireAdmin())
                throw new BusinessRuleException("Only admins can update users password");


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
                throw new ValidationException("Username must not be null or empty");

            if (string.IsNullOrWhiteSpace(Password))
                throw new ValidationException("Password must not be null or empty");


            bool IsValid = false;

            User user=new User();
            try
            {
                 user = UserDAL.Find(Username);
            }
            catch
            {
                throw;
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
            catch 
            {
                throw;
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
            if (!RequireAdmin())
                throw new BusinessRuleException("Only admins can add users");

            return UserDAL.GetUsers();
            
        }


    }
}
