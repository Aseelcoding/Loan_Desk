using System.Configuration;
using System.Data.SqlClient;
using LoanDesk.Models;
using System.Data;
using System;
namespace DAL
{
    public class UserDAL
    {
        private readonly string  ConnectionString = ConfigurationManager.ConnectionStrings["LoanDeskDB"].ConnectionString;


        public bool AddNewUser(User user) 
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
           (@Username,
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

            connection.Open();

            try
            {

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
    }
}
