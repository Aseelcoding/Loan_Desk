using System.Configuration;
using System.Data.SqlClient;
using LoanDesk.Models;
using System.Data;
using System;
namespace DAL
{
    public class UserDAL
    {
        private static readonly string  ConnectionString = ConfigurationManager.ConnectionStrings["LoanDeskDB"].ConnectionString;


        public static bool IsAdminExist() 
        {
            bool IsExist=false;
            string Role = "Admin";
           
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = @"SELECT TOP 1 IsActive FROM Users
                                where Role=@Role and IsActive=1;";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@Role", SqlDbType.VarChar, 30).Value = Role;
          

            try
            {
                connection.Open();
                object Result = cmd.ExecuteScalar();

                if (Result!=DBNull.Value&&Result!=null)
                {
                    bool IsActive;
                    IsActive = (bool)Result;

                    if (IsActive == true)
                    {
                        IsExist = true;
                    }
                }
                else
                {
                    IsExist=false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to add new user \n\nDetails:", ex);
            }
            finally { connection.Close(); connection.Dispose();}

            return IsExist;
        }
        public static bool AddNewUser(User user) 
        {
            bool IsAdded = false;

                SqlConnection connection =new SqlConnection(ConnectionString);

            string query = @"
            INSERT INTO [dbo].[Users]
           ([Username]
           ,[PasswordHash]
           ,[PasswordSalt]
           ,[Role]
           ,[IsActive])
            VALUES
           (
            @Username,
            @PasswordHash,
            @PasswordSalt,
            @Role,
            @IsActive
           ) select scope_identity();";

            SqlCommand cmd =new SqlCommand(query, connection);
            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 15).Value = user.Username;
            cmd.Parameters.Add("@PasswordHash", SqlDbType.VarChar, 500).Value = user.PasswordHash;
            cmd.Parameters.Add("@PasswordSalt",SqlDbType.VarChar,500).Value = user.PasswordSalt;
            cmd.Parameters.Add("@Role", SqlDbType.VarChar, 30).Value = user.Role;
            cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = user.IsActive;

           

            try
            {
                connection.Open();
                object Result = cmd.ExecuteScalar();

                if (Result != null && Result != DBNull.Value)
                    IsAdded = true;

                int ID;
                
               if( int.TryParse(Result.ToString(), out ID))
                {
                    user.ID = ID;
                }
               
              
            }
            catch(Exception ex)
            {
                throw new Exception("Failed to add new user \n\nDetails:", ex);
            }
            finally { connection.Close(); connection.Dispose(); }

            return IsAdded;

        }
        
        public static User Find(string Username) 
        {
            User user = new User();
            SqlConnection connection = new SqlConnection(ConnectionString);
            string query = @"

                  SELECT [ID]
                 ,[Username]
                ,[PasswordHash]
                ,[PasswordSalt]
                ,[Role]
                 ,[IsActive]
                FROM [dbo].[Users]
                 where [Username]=@Username
                        ;";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.Add("@Username", SqlDbType.VarChar, 15).Value = Username;

          

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                  

                    int UID;
                    if (!int.TryParse(reader["ID"].ToString(), out UID))
                        return null;


                    user.ID = UID;
                    user.Username = reader["Username"].ToString();
                    user.Role = reader["Role"].ToString();
                    user.PasswordHash = reader["PasswordHash"].ToString();
                    user.PasswordSalt = reader["PasswordSalt"].ToString();

                    if ((bool)reader["IsActive"] == true)
                    {
                        user.IsActive = true;
                    }
                    else
                        user.IsActive = false;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                connection.Close(); connection.Dispose();
            }

            return user;
            
        }


    }
}
