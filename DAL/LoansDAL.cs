using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

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
            var dtLoans = new DataTable("Loans");
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
                using (var connection = new SqlConnection(ConnectionString))
                using (var cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

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
            string query_1 = @"
        INSERT INTO [dbo].[Loans]
        ([EquipmentID], [BorrowerID], [UserID], [Quantity],
         [LoanedAt], [DueAt], [ReturnedAt], [Status],
         [LateFee], [FinePaid])
        VALUES
        (@EquipmentID, @BorrowerID, @UserID, @Quantity,
         @LoanedAt, @DueAt, @ReturnedAt, @Status,
         @LateFee, @FinePaid);";

            string query_2 = @"
        UPDATE Equipment
        SET AvailableQuantity = AvailableQuantity - @Quantity
        WHERE ID = @EquipmentID
          AND AvailableQuantity >= @Quantity;";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand(query_1, connection, transaction))
                            {
                                cmd.Parameters.Add("@EquipmentID", SqlDbType.Int).Value = NewLoan.EquipmentID;
                                cmd.Parameters.Add("@BorrowerID", SqlDbType.Int).Value = NewLoan.BorrowerID;
                                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = NewLoan.UserID;
                                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = NewLoan.Quantity;
                                cmd.Parameters.Add("@LoanedAt", SqlDbType.DateTime).Value = NewLoan.LoanedAt;
                                cmd.Parameters.Add("@DueAt", SqlDbType.DateTime).Value = NewLoan.DueAt;
                                cmd.Parameters.Add("@Status", SqlDbType.VarChar, 25).Value = NewLoan.Status;

                                SqlParameter lateFeeParameter =
                                    cmd.Parameters.Add("@LateFee", SqlDbType.Decimal);
                                lateFeeParameter.Precision = 10;
                                lateFeeParameter.Scale = 2;
                                lateFeeParameter.Value = NewLoan.LateFee;

                                cmd.Parameters.Add("@ReturnedAt", SqlDbType.DateTime).Value =
                                    NewLoan.ReturnedAt.HasValue
                                        ? (object)NewLoan.ReturnedAt.Value
                                        : DBNull.Value;

                                cmd.Parameters.Add("@FinePaid", SqlDbType.Bit).Value =
                                    NewLoan.FinePaid.HasValue
                                        ? (object)NewLoan.FinePaid.Value
                                        : DBNull.Value;

                                cmd.ExecuteNonQuery();
                            }

                            using (SqlCommand cmd = new SqlCommand(query_2, connection, transaction))
                            {
                                cmd.Parameters.Add("@EquipmentID", SqlDbType.Int).Value = NewLoan.EquipmentID;
                                cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = NewLoan.Quantity;

                                int affectedRows = cmd.ExecuteNonQuery();

                                if (affectedRows == 0)
                                {
                                    throw new InvalidOperationException(
                                        "Equipment not found or insufficient available quantity.");
                                }
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Add New Loan");
            }
        }

        public static decimal GetLateFee(int ID)
        {
            decimal LateFee;
            string query = @"select COALESCE(SUM(LateFee),0) as LateFee from loans
                            where BorrowerID =@ID;";

            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                using (var cmd = new SqlCommand(query, connection))
                {
                    connection.Open();

                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

                    object Result = cmd.ExecuteScalar();

                    if (Result == null || Result == DBNull.Value)
                        return 0;

                    decimal.TryParse(Result.ToString(), out LateFee);
                }
            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Get Late Fee");
            }

            return LateFee;
        }
    }
}