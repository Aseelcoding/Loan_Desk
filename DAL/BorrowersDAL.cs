using System.Configuration;
using System.Data.SqlClient;
using LoanDesk.Models;
using System.Data;
using System;
using System.Reflection;

namespace DAL
{
    public class BorrowersDAL
    {           
        
            //catch (SqlException ex) 
            //{
            //    throw SqlErrorMapper.Map(ex, "Add New borrower");
            //}
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["LoanDeskDB"].ConnectionString;

        public static DataTable GetBorrowers()
        {
            DataTable dtBorrowers = new DataTable("Borrowers");

            string query = @"SELECT   B.ID,
         B.FullName,
         B.Passport,
         B.Phone,
         B.IsActive,
         count(CASE L.Status WHEN 'Active' THEN 1 END) AS ActiveLoans,
         SUM(CASE L.FinePaid WHEN 0 THEN L.LateFee ELSE 0 END) AS UnpaidFines
FROM     Borrowers AS B
         LEFT OUTER JOIN
         Loans AS L
         ON B.ID = L.BorrowerID
GROUP BY B.ID, B.FullName, B.Passport, B.Phone, B.IsActive;";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dtBorrowers.Load(reader);
                    }
                }
            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Get Borrowers");
            }

            return dtBorrowers;
        }
        public static bool AddNewBorrower(Borrower Newborrower)
        {
            bool IsAdded = false;

            string query = @"INSERT  INTO [dbo].[Borrowers] ([FullName], [Passport], [Phone], [IsActive])
                            VALUES                        (@FullName, @Passport, @Phone, @IsActive);";

            try 
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd=new SqlCommand(query, connection)) 
                {
                    cmd.Parameters.AddWithValue("@FullName", Newborrower.FullName);
                    cmd.Parameters.AddWithValue("@Passport", Newborrower.Passport);
                    cmd.Parameters.AddWithValue("Phone", Newborrower.Phone);
                    cmd.Parameters.AddWithValue("@IsActive", Newborrower.IsActive);
                    connection.Open();

                    int AffectedRows = cmd.ExecuteNonQuery();

                    if(AffectedRows>0)
                        IsAdded = true;
                }
            }
            catch (SqlException ex) 
            {
                throw SqlErrorMapper.Map(ex, "Add New borrower");
            }

            return IsAdded;
        }
        public static Borrower GetBorrowerByID(int BorrowerID) 
        {
            Borrower borrower = null;

            string query = @"SELECT [ID],
       [FullName],
       [Passport],
       [Phone],
       [IsActive]
FROM   [dbo].[Borrowers]
WHERE  ID = @BorrowerID;";

            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@BorrowerID", BorrowerID);
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) 
                    {
                        borrower=new Borrower();

                        int BID = -1;
                        int.TryParse(reader["ID"].ToString(), out BID);
                        borrower.ID=BID;

                        borrower.FullName=reader["FullName"].ToString();
                        borrower.Passport=reader["Passport"].ToString();
                        borrower.Phone = reader["Phone"].ToString();
                        if ((bool)reader["IsActive"] == true)
                            borrower.IsActive = true;
                        else borrower.IsActive = false;
                                       
                    }
                }
            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Get borrower by id");
            }
            return borrower;
        }
        public static Borrower GetBorrowerByPassport(string Passport)
        {
            Borrower borrower = null;

            string query = @"SELECT [ID],
       [FullName],
       [Passport],
       [Phone],
       [IsActive]
FROM   [dbo].[Borrowers]
WHERE  Passport = @Passport;";

            try
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Passport", Passport);
                    connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        borrower = new Borrower();

                        int BID = -1;
                        int.TryParse(reader["ID"].ToString(), out BID);
                        borrower.ID = BID;

                        borrower.FullName = reader["FullName"].ToString();
                        borrower.Passport = reader["Passport"].ToString();
                        borrower.Phone = reader["Phone"].ToString();
                        if ((bool)reader["IsActive"] == true)
                            borrower.IsActive = true;
                        else borrower.IsActive = false;

                    }
                }
            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Get borrower by passport");
            }
            return borrower;
        }
        public static bool UpdateBorrower (Borrower borrower) 
        {
            bool IsUpdated = false;

            string query = @"UPDATE [dbo].[Borrowers]
SET    [FullName] = @FullName,
       [Passport] = @Passport,
       [Phone]    = @Phone
WHERE  ID = @ID;";


            try 
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ID", borrower.ID);
                    cmd.Parameters.AddWithValue("@FullName", borrower.FullName);
                    cmd.Parameters.AddWithValue("@Passport", borrower.Passport);
                    cmd.Parameters.AddWithValue("@Phone", borrower.Phone);
                    
                    connection.Open();

                    int AffectedRows = cmd.ExecuteNonQuery();

                    if (AffectedRows > 0)
                        IsUpdated = true;

                }

            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Update borrower");
            }

            return IsUpdated;
        }
        public static bool DeactivateBorrowerByID(int BorrowerID) 
        {
            bool IsDeactivate = false;

            string query = @"UPDATE [dbo].[Borrowers]
                    SET    [IsActive] = 0
                         WHERE  ID = @ID;";

            try 
            {
                using (SqlConnection connection =new SqlConnection(ConnectionString))
                using (SqlCommand cmd =new SqlCommand(query, connection)) 
                {
                    connection.Open();

                    cmd.Parameters.AddWithValue("@ID", BorrowerID);

                    int AffectedRows = cmd.ExecuteNonQuery();
                    if (AffectedRows > 0)
                        IsDeactivate = true;
                }
            }
            catch (SqlException ex) 
            {
                throw SqlErrorMapper.Map(ex, "Deactivate Borrower");
            }

            return IsDeactivate;
        }
        public static bool ActivateBorrowerByID(int BorrowerID)
        {
            bool IsActivated = false;

            string query = @"UPDATE [dbo].[Borrowers]
                    SET    [IsActive] = 1
                         WHERE  ID = @ID;";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    connection.Open();

                    cmd.Parameters.AddWithValue("@ID", BorrowerID);

                    int AffectedRows = cmd.ExecuteNonQuery();
                    if (AffectedRows > 0)
                        IsActivated = true;
                }
            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Activate Borrower");
            }

            return IsActivated;
        }
    }
}