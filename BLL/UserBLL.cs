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
        static public bool RestartRequired = false; 
        static public void Logout() 
        {
            Sessions.ClearUserSessions();
        }
        static private bool RequireAdmin() 
        {
            if (Sessions.CurrentUser == null)
                return false;

            if (Sessions.CurrentUser.Role == "Admin")
                return true;
            else 
                return false;
        }
        static public int CountActiveAdmins() 
        {
            int count = 0;
            try
            {
                count = UserDAL.CountActiveAdmins();
            }
            catch (SqlException ex) 
            {
                Logger.Write(ex);
                throw;
            }
            return count;
        }
        static public int CountActiveUsers()
        {
            int count = 0;
            try { count= UserDAL.CountActiveUsers(); }
            catch(SqlException ex) 
            {
             Logger.Write(ex);
                throw;
            }
            return count;
        }
        static public bool IsAdminExist() 
        {
            bool IsExist = false;
            try
            {
                IsExist = UserDAL.IsAdminExist();
            }
            catch (SqlException ex) 
            {
                Logger.Write(ex);
                throw;
            }
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
                catch (SqlException ex)
                {
                    Logger.Write(ex);
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
            catch (SqlException ex)
            {
                Logger.Write(ex);
                throw;
            }

            if(OldUser!=null&&OldUser.ID!=NewUser.ID)
                IsUsernameTaken = true;
            else
            {
                IsUsernameTaken = false;
            }
            return IsUsernameTaken;
        }
        public static bool UpdateUser(User user)
        {
            if (!RequireAdmin())
                throw new BusinessRuleException("Only admins can update users");

            bool IsUpdated = false;

            if (CheckUser(user))
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

                    try
                    {
                        IsUpdated = UserDAL.UpdateUser(user);
                    }
                    catch(SqlException ex) 
                    {
                        Logger.Write(ex);
                        throw;
                    }

                                         if(IsUpdated)
                                    RestartRequired = true;
                            
                                        return IsUpdated;
                                    
                        
                      }
                    else
                    {

                    try
                    {
                        IsUpdated = UserDAL.UpdateUser(user);
                    }
                    catch(SqlException ex) 
                    {
                        Logger.Write(ex);
                        throw;
                    }

                            if(IsUpdated)
                            Sessions.CreateUserSession(user.ID, user.Username, user.Role, user.IsActive);
                           
                           
                            
                        

                    }
                }

            
     


                return IsUpdated;
        }
        public static bool DeleteUser(User user)
        {
            bool IsDeleted = false;
            if (!RequireAdmin())
                throw new BusinessRuleException("Only admins can delete users");

            if (user.ID == Sessions.CurrentUser.ID)
                throw new BusinessRuleException("You can not delete loging account.");

            try
            {
                IsDeleted = UserDAL.DeleteUser(user);
            }
            catch (SqlException ex) 
            {
                Logger.Write(ex);
                throw;
            }
            return IsDeleted;


        }
        public static bool ActivateUser(int ID)
        {
            bool IsActivated = false;
            if (!RequireAdmin())
                throw new BusinessRuleException("Only admins can activate users");


            try
            {
                IsActivated = UserDAL.ActivateUser(ID);
            }
            catch (SqlException ex) 
            {
                Logger.Write(ex);
                throw;
            }

            return IsActivated;
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


            try
            {
                IsUpdated = UserDAL.UpdateUserPassword(ID, NewPasswordHash, NewPasswordSalt);
            }
            catch (SqlException ex) 
            {
                Logger.Write(ex);
                throw;
            }


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
            catch(SqlException ex)
            {
                Logger.Write(ex);
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
            catch (SqlException ex)
            {
                Logger.Write(ex);
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
            DataTable dtUsers = null;
            if (!RequireAdmin())
                throw new BusinessRuleException("Only admins can view users");

            try
            {
                dtUsers = UserDAL.GetUsers();
            }
            catch(SqlException ex) 
            {
                Logger.Write(ex);
                throw;
            }
            return dtUsers;
            
        }


    }
}
