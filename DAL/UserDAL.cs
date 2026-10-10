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


        public static int CountActiveAdmins() 
        {
            int Counter = -1;

          

            string query = @"SELECT Count(ID) AS CountAdmins
                        FROM Users
                WHERE Users.Role='Admin' and Users.IsActive=1;";

            

            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {



                    connection.Open();

                    object Result = cmd.ExecuteScalar();

                    if (Result != null && Result != DBNull.Value)
                    {
                        int.TryParse(Result.ToString(), out Counter);

                    }
                    else
                    {
                        throw new LoanDesk.Models.Exceptions.DataAccessException("Could not get the number of admins");
                    }
                }
            }
            catch (SqlException ex) 
            {
                throw SqlErrorMapper.Map(ex, "Get Number of Admins");
            }
            

            return Counter;

        }
        public static int CountActiveUsers()
        {
            int Counter = -1;
         
            string query = @"SELECT Count(ID) AS CountUsers
                        FROM Users
                WHERE Users.IsActive=1;";
            
            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    object Result = cmd.ExecuteScalar();
                    if (Result != null && Result != DBNull.Value)
                    {
                        int.TryParse(Result.ToString(), out Counter);
                    }
                    else
                    {
                        throw new LoanDesk.Models.Exceptions.DataAccessException("Could not get the number of users");
                    }
                }
            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Get Number of active users");
            }
         
            return Counter;
        }
        public static bool IsAdminExist() 
        {
            bool IsExist=false;
            string Role = "Admin";
           
         
            string query = @"SELECT TOP 1 IsActive FROM Users
                                where Role=@Role and IsActive=1;";
          
            
          

            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@Role", SqlDbType.VarChar, 30).Value = Role;

                    connection.Open();
                    object Result = cmd.ExecuteScalar();

                    if (Result != DBNull.Value && Result != null)
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
                        IsExist = false;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Check if user exist.");
            }
           

            return IsExist;
        }
        public static bool AddNewUser(User user) 
        {
            bool IsAdded = false;

               

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

           

           

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {

                    cmd.Parameters.Add("@Username", SqlDbType.VarChar, 15).Value = user.Username;
                    cmd.Parameters.Add("@PasswordHash", SqlDbType.VarChar, 500).Value = user.PasswordHash;
                    cmd.Parameters.Add("@PasswordSalt", SqlDbType.VarChar, 500).Value = user.PasswordSalt;
                    cmd.Parameters.Add("@Role", SqlDbType.VarChar, 30).Value = user.Role;
                    cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = user.IsActive;

                    connection.Open();
                    object Result = cmd.ExecuteScalar();



                    int ID;
                    if (Result != null && Result != DBNull.Value)
                    {
                        if (int.TryParse(Result.ToString(), out ID))
                        {
                            user.ID = ID;
                            IsAdded = true;
                        }
                        else
                        {
                            IsAdded = false;
                        }
                    }
                    else { IsAdded = false; }
                }
              
            }
            catch(SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Add new user");
            }
           

            return IsAdded;

        }
        public static bool ActivateUser(int ID)
        {
            bool IsActivated = false;
            
            bool IsActive = true;
            string query = @"
                            UPDATE [dbo].[Users]
                            SET [IsActive] =@IsActive
                             WHERE ID=@ID;";
         

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = IsActive;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                    connection.Open();
                    int AffectedRows = cmd.ExecuteNonQuery();
                    if (AffectedRows > 0)
                        IsActivated = true;
                }
            }
            catch (SqlException ex) 
            {
                throw SqlErrorMapper.Map(ex, "Activate a user");
            }
           
            return IsActivated;
        }
        public static bool UpdateUser(User user) 
        {
            bool IsUpdated = false;

         

            string query = @"UPDATE [dbo].[Users]
                                SET Username= @Username
                                 , Role=@Role
                                
                                WHERE ID=@ID;";
           

           


            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = user.ID;
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar, 15).Value = user.Username;
                    cmd.Parameters.Add("@Role", SqlDbType.VarChar, 30).Value = user.Role;

                    connection.Open();
                    int AffectedRows = cmd.ExecuteNonQuery();

                    if (AffectedRows > 0)
                        IsUpdated = true;

                }


            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "update the user");
            }
           

            return IsUpdated;

        }
        public static bool DeleteUser(User user) 
        {
            bool Isdeleted = false;

           

            bool InActive = false;
            string query = @"

                            UPDATE [dbo].[Users]
                            SET [IsActive] =@IsActive
                             WHERE ID=@ID;";

     
        

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = InActive;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = user.ID;
                    connection.Open();
                    int AffectedRows = cmd.ExecuteNonQuery();

                    if (AffectedRows > 0)
                        Isdeleted = true;


                }

            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Delete the user");
            }
            

            return Isdeleted;

        }
        public static bool UpdateUserPassword(int ID,string NewPasswordHash,string NewPasswordSalt)
        {
            bool IsUpdated = false;

           

            string query = @"UPDATE [dbo].[Users]
                                SET PasswordHash= @PasswordHash
                                ,PasswordSalt=@PasswordSalt
                                WHERE ID=@ID;";


        

           try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
                    cmd.Parameters.Add("@PasswordHash", SqlDbType.VarChar, 500).Value = NewPasswordHash;
                    cmd.Parameters.Add("@PasswordSalt", SqlDbType.VarChar, 500).Value = NewPasswordSalt;
                    
                    connection.Open();
                    int AffectedRows = cmd.ExecuteNonQuery();

                    if (AffectedRows > 0)
                        IsUpdated = true;


                }

            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Update user password.");
            }
          

            return IsUpdated;


        }
        public static User FindByUsername(string Username) 
        {
           
         
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

           

          

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar, 15).Value = Username;

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        return new User
                        {
                            ID = (int)reader["ID"],
                            Username = reader["Username"].ToString(),
                            Role = reader["Role"].ToString(),
                            PasswordHash = reader["PasswordHash"].ToString(),
                            PasswordSalt = reader["PasswordSalt"].ToString(),
                            IsActive = (bool)reader["IsActive"]
                        };

                    }
                }
            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Find the user.");

            }
            

           
            
        }
        public static User FindByID(int ID) 
        {
        

            string query = @"

                  SELECT [ID]
                 ,[Username]
                ,[PasswordHash]
                ,[PasswordSalt]
                ,[Role]
                 ,[IsActive]
                FROM [dbo].[Users]
                 where [ID]=@ID;";





            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;

                        return new User
                        {
                            ID = ID,
                            Username = reader["Username"].ToString(),
                            Role = reader["Role"].ToString(),
                            PasswordHash = reader["PasswordHash"].ToString(),
                            PasswordSalt = reader["PasswordSalt"].ToString(),
                            IsActive = (bool)reader["IsActive"]
                        };
                    }
                }
            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Find User By ID.");

            }


           

        }
        public static DataTable GetUsers() 
        {
            DataTable dtUsers = new DataTable("Users");

            

            string query = @"
            SELECT [ID]
             ,[Username]
             ,[Role]
             ,[IsActive]
             FROM [dbo].[Users];";

           

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        dtUsers.Load(reader);

                    }

                        
                }
            }
            catch (SqlException ex) 
            {
                throw SqlErrorMapper.Map(ex, "Get all users.");
            }
           

            return dtUsers;
        }

    }
}

