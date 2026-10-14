using System.Configuration;
using System.Data.SqlClient;
using LoanDesk.Models;
using System.Data;
using System;
using System.Reflection;

namespace DAL
{
    public class LoansDAL
    {
        //catch (SqlException ex) 
        //{
        //    throw SqlErrorMapper.Map(ex, "Add New borrower");
        //}
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["LoanDeskDB"].ConnectionString;

        public static DataTable GetAllLoans()
        {

            var dtLoans=new DataTable("Loans");
            string query = @"SELECT [ID]
      ,[EquipmentID]
      ,[BorrowerID]
      ,[UserID]
      ,[Quantity]
      ,[LoanedAt]
      ,[DueAt]
      ,[ReturnedAt]
      ,[Status]
      ,[LateFee]
      ,[FinePaid]
  FROM [dbo].[Loans]
;";


            try 
            {
                using (var connection =new SqlConnection(ConnectionString))
                using (var cmd = new SqlCommand(query, connection)) 
                {
                    connection.Open();
                    SqlDataReader reader =cmd.ExecuteReader();

                    dtLoans.Load(reader);
                }
            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Get all loans");
            }

            return dtLoans;
        }
        public static bool AddLoan(LoanDesk.Models.Loan NewLoan) 
        {
            bool IsAdded = false;

            string query = @"INSERT INTO [dbo].[Loans]
           ([EquipmentID]
           ,[BorrowerID]
           ,[UserID]
           ,[Quantity]
           ,[LoanedAt]
           ,[DueAt]
           ,[ReturnedAt]
           ,[Status]
           ,[LateFee]
           ,[FinePaid])
     VALUES
           (@EquipmentID
           ,@BorrowerID
           ,@UserID
           ,@Quantity
           ,@LoanedAt
           ,@DueAt
           ,@ReturnedAt
           ,@Status
           ,@LateFee
           ,@FinePaid);";

            try 
            {
                using (var connection = new SqlConnection(ConnectionString))
                using (var cmd =new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.Add("@EquipmentID", SqlDbType.Int).Value = NewLoan.EquipmentID;
                    cmd.Parameters.Add("@BorrowerID", SqlDbType.Int).Value = NewLoan.BorrowerID;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = NewLoan.UserID;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = NewLoan.Quantity;
                    cmd.Parameters.Add("@LoanedAt", SqlDbType.DateTime).Value = NewLoan.LoanedAt;
                    cmd.Parameters.Add("@DueAt", SqlDbType.DateTime).Value = NewLoan.DueAt;
                    cmd.Parameters.Add("@Status", SqlDbType.VarChar, 25).Value = NewLoan.Status;
                    cmd.Parameters.Add("@LateFee", SqlDbType.Decimal,24).Value = NewLoan.LateFee;
                    
                    if (NewLoan.ReturnedAt.HasValue)
                        cmd.Parameters.Add("@ReturnedAt", SqlDbType.DateTime).Value = NewLoan.ReturnedAt;
                    else
                        cmd.Parameters.Add("@ReturnedAt", SqlDbType.DateTime).Value =DBNull.Value;

                    if(NewLoan.FinePaid.HasValue)
                        cmd.Parameters.Add("@FinePaid",SqlDbType.Bit).Value = NewLoan.FinePaid;
                    else
                        cmd.Parameters.Add("@FinePaid", SqlDbType.Bit).Value = DBNull.Value;

                    int AffectedRows=cmd.ExecuteNonQuery();
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
    }
}
