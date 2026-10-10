using DAL;
using LoanDesk.Models;
using System;
using System.Data;

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

        private static void RequireAdmin()
        {
            if (Sessions.CurrentUser?.Role != "Admin")
                throw new BusinessRuleException("Only admins can perform this action");
        }

        public static int CountActiveAdmins()
        {
            return UserDAL.CountActiveAdmins();
        }

        public static int CountActiveUsers()
        {
            return UserDAL.CountActiveUsers();
        }

        public static bool IsAdminExist()
        {
            return UserDAL.IsAdminExist();
        }

        public static void CheckPassword(string Password)
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

            
        }

        private static void CheckUser(User user)
        {
            if (user == null)
                throw new ArgumentNullException("user");

            user.Username = user.Username?.Trim();
            

            if (string.IsNullOrWhiteSpace(user.Username))
                throw new ValidationException("Username must not be null or empty");

            if (user.Username.Length > 15 || user.Username.Length < 5)
                throw new ValidationException("Username must be between 5 and 15.");

            if (!System.Text.RegularExpressions.Regex.IsMatch(user.Username, @"^[A-Za-z0-9]+$"))
                throw new ValidationException("Username must contain only letters and numbers");

            if (user.Role != "Admin" && user.Role != "Staff")
                throw new BusinessRuleException("Role must be Admin or Staff.");
        }

        public static bool AddNewUser(User user, string Password)
        {
            if (IsAdminExist())
                RequireAdmin();

            bool IsAdded = false;
            CheckUser(user);
            CheckPassword(Password);
            
                if (UserDAL.FindByUsername(user.Username) == null)
                {
                    user.PasswordSalt = PasswordHasher.GenerateSalt();
                    user.PasswordHash = PasswordHasher.HashPassword(Password, user.PasswordSalt);

                    IsAdded = UserDAL.AddNewUser(user);
                }
                else
                {
                    throw new BusinessRuleException("duplicate username , please enter a uniqeu username.");
                }
            

            return IsAdded;
        }

        private static bool IsUsernameTaken(User NewUser)
        {
            bool IsUsernameTaken = false;
            User OldUser;

            OldUser = UserDAL.FindByUsername(NewUser.Username);

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

            RequireAdmin();

            CheckUser(user);

            if (IsUsernameTaken(user))
            {
                throw new BusinessRuleException("duplicate username , please enter a uniqeu username.");
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

            return IsUpdated;
        }

        public static bool DeleteUser(User user)
        {
            RequireAdmin();

            if (user.ID == Sessions.CurrentUser.ID)
                throw new BusinessRuleException("You can not delete loging account.");

            return UserDAL.DeleteUser(user);
        }

        public static bool ActivateUser(int ID)
        {
            RequireAdmin();

            return UserDAL.ActivateUser(ID);
        }
        
        public static bool UpdateUserPassword(int ID, string OldPassword, string NewPassword)
        {
            bool isSelf = Sessions.CurrentUser?.ID == ID;
            if (!isSelf)
                RequireAdmin();   
            else
            {
                User user = UserDAL.FindByID(ID);
                if (user == null || !PasswordHasher.VerifyPassword(OldPassword, user.PasswordSalt, user.PasswordHash))
                    throw new ValidationException("Old password is incorrect");
            }

            CheckPassword(NewPassword);

            string salt = PasswordHasher.GenerateSalt();
            string hash = PasswordHasher.HashPassword(NewPassword, salt);
            return UserDAL.UpdateUserPassword(ID, hash, salt);
        }

        public static bool Login(string Username, string Password)
        {
            bool IsValid = false;

            User user = new User();
            Username = Username?.Trim();
            if (string.IsNullOrWhiteSpace(Username))
                throw new ValidationException("Username must not be null or empty");

            if (string.IsNullOrWhiteSpace(Password))
                throw new ValidationException("Password must not be null or empty");

            user = UserDAL.FindByUsername(Username);

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

            return IsValid;
        }

        public static DataTable GetUsers()
        {
            RequireAdmin();

            return UserDAL.GetUsers();
        }

    }
}