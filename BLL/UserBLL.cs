using DAL;
using Loan_Desk;
using LoanDesk.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static LoanDesk.Models.Exceptions;

namespace BLL
{
    public class UserBLL
    {
        public static bool RestartRequired = false;

        public static void Logout()
        {
            Sessions.ClearUserSessions();
        }

        private static bool RequireAdmin()
        {
            if (Sessions.CurrentUser == null)
                return false;

            if (Sessions.CurrentUser.Role == "Admin")
                return true;
            else
                return false;
        }

        public static int CountActiveAdmins()
        {
            int count = 0;
            try
            {
                count = UserDAL.CountActiveAdmins();
            }
            catch (Exception ex)
            {
                if (!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException))
                {
                    Logger.Write(ex);
                }

                throw;
            }
            return count;
        }

        public static int CountActiveUsers()
        {
            int count = 0;
            try { count = UserDAL.CountActiveUsers(); }
            catch (Exception ex)
            {
                if (!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException))
                {
                    Logger.Write(ex);
                }

                throw;
            }
            return count;
        }

        public static bool IsAdminExist()
        {
            bool IsExist = false;
            try
            {
                IsExist = UserDAL.IsAdminExist();
            }
            catch (Exception ex)
            {
                if (!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException))
                {
                    Logger.Write(ex);
                }

                throw;
            }
            return IsExist;
        }

        public static bool CheckPassword(string Password)
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

            if (utilities.utilities.IsStringContainSymbol(user.Username))
                throw new ValidationException("Username must not has any Symbol.");

            if (user.Role != "Admin" && user.Role != "Staff")
                throw new BusinessRuleException("Role must be Admin or Staff.");

            return true;
        }

        public static bool AddNewUser(User user, string Password)
        {
            if(IsAdminExist())
             { if (!RequireAdmin())
                    throw new BusinessRuleException("Only admins can add users");
            }

            bool IsAdded = false;
            if (CheckUser(user) && CheckPassword(Password))
            {
                try
                {
                    if (UserDAL.Find(user.Username) == null)
                    {
                        user.PasswordSalt = PasswordHasher.GenerateSalt();
                        user.PasswordHash = PasswordHasher.HashPassword(Password, user.PasswordSalt);

                        IsAdded = UserDAL.AddNewUser(user);
                    }
                    else
                    {
                        throw new BusinessRuleException("duplicate username , please enter a uniqeu username.");
                    }
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

            return IsAdded;
        }

        public static bool IsUsernameTaken(User NewUser)
        {
            bool IsUsernameTaken = false;
            User OldUser;
            try
            {
                OldUser = UserDAL.Find(NewUser.Username);
            }
            catch (Exception ex)
            {
                if (!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException))
                {
                    Logger.Write(ex);
                }

                throw;
            }

            if (OldUser != null && OldUser.ID != NewUser.ID)
                IsUsernameTaken = true;
            else
            {
                IsUsernameTaken = false;
            }
            return IsUsernameTaken;
        }

        public static bool UpdateUser(User user)
        {

            bool IsUpdated = false;

            try
            {
                if (!RequireAdmin())
                    throw new BusinessRuleException("Only admins can update users");

                

                if (!CheckUser(user))
                { return IsUpdated; }

                if (IsUsernameTaken(user))
                {
                    throw new ValidationException("duplicate username , please enter a uniqeu username.");
                }

                if (Sessions.CurrentUser.ID != user.ID)
                {
                   
                        IsUpdated = UserDAL.UpdateUser(user);
                    
                }
                else
                {
                    if (user.Role != Sessions.CurrentUser.Role)
                    {
                        if (CountActiveAdmins() <= 1)
                        {
                            throw new BusinessRuleException("You are the last admin you can not be a staff.");
                        }
                        
                            IsUpdated = UserDAL.UpdateUser(user);
                        

                        if (IsUpdated)
                            RestartRequired = true;

                        return IsUpdated;
                    }
                    else
                    {

                        IsUpdated = UserDAL.UpdateUser(user);

                        if (IsUpdated)
                            Sessions.CreateUserSession(user.ID, user.Username, user.Role, user.IsActive);
                    }
                }

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

        public static bool DeleteUser(User user)
        {
            bool IsDeleted = false;



            try
            {
                if (!RequireAdmin())
                    throw new BusinessRuleException("Only admins can delete users");

                if (user.ID == Sessions.CurrentUser.ID)
                    throw new BusinessRuleException("You can not delete loging account.");

                
                    IsDeleted = UserDAL.DeleteUser(user);
                
              

            }
            catch (Exception ex)
            {
                if (!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException))
                {
                    Logger.Write(ex);
                }

                throw;
            }
            return IsDeleted;
        }

        public static bool ActivateUser(int ID)
        {
            bool IsActivated = false;
            

            try
            {
                if (!RequireAdmin())
                    throw new BusinessRuleException("Only admins can activate users");

                IsActivated = UserDAL.ActivateUser(ID);
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

        public static bool UpdateUserPassword(int ID, string Username, string OldPassword, string NewPassword)
        {
            bool IsUpdated = false;

            

            try
            {
                if (!RequireAdmin())
                    throw new BusinessRuleException("Only admins can update users password");

                if (!IsPasswordCorrect(Username, OldPassword))
                    return IsUpdated;

                if (!CheckPassword(NewPassword))
                    return IsUpdated;

                string NewPasswordSalt = PasswordHasher.GenerateSalt();
                string NewPasswordHash = PasswordHasher.HashPassword(NewPassword, NewPasswordSalt);

                IsUpdated = UserDAL.UpdateUserPassword(ID, NewPasswordHash, NewPasswordSalt);
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

        public static bool Login(string Username, string Password)
        {
           

            bool IsValid = false;

            User user = new User();
            try
            {

                if (string.IsNullOrWhiteSpace(Username))
                    throw new ValidationException("Username must not be null or empty");

                if (string.IsNullOrWhiteSpace(Password))
                    throw new ValidationException("Password must not be null or empty");


                user = UserDAL.Find(Username);






                if (user == null)
                    return IsValid;
                else
                {
                    //here we will compare the password with the PasswordHash and PasswordSalt:
                    IsValid = PasswordHasher.VerifyPassword(Password, user.PasswordSalt, user.PasswordHash);
                    if (IsValid)
                    {
                        if (user.IsActive == false)
                        {
                            IsValid = false;
                            return IsValid;
                        }
                        Sessions.CreateUserSession(user.ID, user.Username, user.Role, user.IsActive);
                    }
                }
            }
            catch (Exception ex)
            {
                if (!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException))
                {
                    Logger.Write(ex);
                }

                throw;
            }

          

            return IsValid;
        }

        public static bool IsPasswordCorrect(string Username, string Password)
        {
            

            bool IsValid = false;

            User user = new User();
            try
            {
                if (string.IsNullOrWhiteSpace(Username))
                    throw new ValidationException("Username must not be null or empty");


                user = UserDAL.Find(Username);

                if (user == null)
                    return IsValid;
                else
                {
                    //here we will compare the password with the PasswordHash and PasswordSalt:
                    IsValid = PasswordHasher.VerifyPassword(Password, user.PasswordSalt, user.PasswordHash);
                }
            }
            catch (Exception ex)
            {
                if (!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException))
                {
                    Logger.Write(ex);
                }

                throw;
            }


            

            return IsValid;
        }

        public static DataTable GetUsers()
        {
            DataTable dtUsers = null;
           
            try
            {
                if (!RequireAdmin())
                    throw new BusinessRuleException("Only admins can view users");

                dtUsers = UserDAL.GetUsers();
            }
            catch (Exception ex)
            {
                if (!(ex is Exceptions.ValidationException) && !(ex is Exceptions.BusinessRuleException))
                {
                    Logger.Write(ex);
                }

                throw;
            }
            return dtUsers;
        }
    }
}