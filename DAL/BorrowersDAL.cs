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
                            VALUES                        (@FullName, @Passport, @Phone, IsActive);";

            try 
            {

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                using (SqlCommand cmd=new SqlCommand(query, connection)) 
                {
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

    }
}