using LoanDesk.Models;
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
      ,[LostQuantity]
      ,[ReplacementFee]
      ,[ReplacementPaid]
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
         [LateFee], [FinePaid], [LostQuantity], [ReplacementFee], [ReplacementPaid])
        VALUES
        (@EquipmentID, @BorrowerID, @UserID, @Quantity,
         @LoanedAt, @DueAt, @ReturnedAt, @Status,
         @LateFee, @FinePaid, @LostQuantity, @ReplacementFee, @ReplacementPaid);";

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
                                cmd.Parameters.Add("@LostQuantity", SqlDbType.Int).Value = NewLoan.LostQuantity;
                                AddMoneyParameter(cmd, "@ReplacementFee", NewLoan.ReplacementFee);
                                cmd.Parameters.Add("@ReplacementPaid", SqlDbType.Bit).Value =
                                    NewLoan.ReplacementPaid.HasValue
                                        ? (object)NewLoan.ReplacementPaid.Value
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

        public static bool ReturnEquipment(Loan ReturnedLoan,Equipment equipment) 
        {
            
            string query_1 = @"UPDATE [dbo].[Loans]
        SET [ReturnedAt] = @ReturnedAt,
            [Status]     = @Status,
            [LateFee]    = @LateFee,
            [FinePaid]   = @FinePaid,
            [LostQuantity] = @LostQuantity,
            [ReplacementFee] = @ReplacementFee,
            [ReplacementPaid] = @ReplacementPaid
        WHERE [ID] = @LoanID
          AND [Status] = 'Active';";

            string query_2 = @"
            UPDATE Equipment
            SET AvailableQuantity = @AvailableQuantity
            WHERE ID = @EquipmentID;";


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


                                cmd.Parameters.Add("@LoanID", SqlDbType.Int).Value = ReturnedLoan.ID;
                                cmd.Parameters.Add("@Status", SqlDbType.VarChar, 25).Value = ReturnedLoan.Status;

                                SqlParameter lateFeeParameter =
                                    cmd.Parameters.Add("@LateFee", SqlDbType.Decimal);
                                lateFeeParameter.Precision = 10;
                                lateFeeParameter.Scale = 2;
                                lateFeeParameter.Value = ReturnedLoan.LateFee;

                                cmd.Parameters.Add("@ReturnedAt", SqlDbType.DateTime).Value =
                                    ReturnedLoan.ReturnedAt.HasValue
                                        ? (object)ReturnedLoan.ReturnedAt.Value
                                        : DBNull.Value;

                                cmd.Parameters.Add("@FinePaid", SqlDbType.Bit).Value =
                                    ReturnedLoan.FinePaid.HasValue
                                        ? (object)ReturnedLoan.FinePaid.Value
                                        : DBNull.Value;
                                cmd.Parameters.Add("@LostQuantity", SqlDbType.Int).Value = ReturnedLoan.LostQuantity;
                                AddMoneyParameter(cmd, "@ReplacementFee", ReturnedLoan.ReplacementFee);
                                cmd.Parameters.Add("@ReplacementPaid", SqlDbType.Bit).Value =
                                    ReturnedLoan.ReplacementPaid.HasValue
                                        ? (object)ReturnedLoan.ReplacementPaid.Value
                                        : DBNull.Value;

                                int loanRows = cmd.ExecuteNonQuery();
                                if (loanRows == 0)
                                    throw new InvalidOperationException("This loan was already processed or could not be found.");
                            }

                            using (SqlCommand cmd = new SqlCommand(query_2, connection, transaction))
                            {
                                cmd.Parameters.Add("@EquipmentID", SqlDbType.Int).Value = equipment.ID;
                                cmd.Parameters.Add("@AvailableQuantity", SqlDbType.Int).Value = equipment.AvailableQuantity;

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
                throw SqlErrorMapper.Map(ex, "Return Equipment");
            }
           
        }

        public static bool MarkLoanLost(Loan loan, Equipment equipment, int returnedQuantity)
        {
            string updateLoan = @"
UPDATE dbo.Loans
SET Status = @Status,
    LostQuantity = @LostQuantity,
    ReplacementFee = @ReplacementFee,
    ReplacementPaid = @ReplacementPaid,
    LateFee = @LateFee,
    FinePaid = @FinePaid
WHERE ID = @ID AND Status = 'Active';";

            string updateEquipment = @"
UPDATE dbo.Equipment
SET TotalQuantity = TotalQuantity - @LostQuantity,
    AvailableQuantity = AvailableQuantity + @ReturnedQuantity
WHERE ID = @EquipmentID
  AND TotalQuantity >= @LostQuantity
  AND AvailableQuantity + @ReturnedQuantity <= TotalQuantity - @LostQuantity;";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand cmd = new SqlCommand(updateLoan, connection, transaction))
                            {
                                cmd.Parameters.Add("@ID", SqlDbType.Int).Value = loan.ID;
                                cmd.Parameters.Add("@Status", SqlDbType.VarChar, 25).Value = loan.Status;
                                cmd.Parameters.Add("@LostQuantity", SqlDbType.Int).Value = loan.LostQuantity;
                                AddMoneyParameter(cmd, "@ReplacementFee", loan.ReplacementFee);
                                cmd.Parameters.Add("@ReplacementPaid", SqlDbType.Bit).Value = loan.ReplacementPaid.HasValue
                                    ? (object)loan.ReplacementPaid.Value : DBNull.Value;
                                AddMoneyParameter(cmd, "@LateFee", loan.LateFee);
                                cmd.Parameters.Add("@FinePaid", SqlDbType.Bit).Value = loan.FinePaid.HasValue
                                    ? (object)loan.FinePaid.Value : DBNull.Value;

                                if (cmd.ExecuteNonQuery() == 0)
                                    throw new InvalidOperationException("This loan has already been processed.");
                            }

                            using (SqlCommand cmd = new SqlCommand(updateEquipment, connection, transaction))
                            {
                                cmd.Parameters.Add("@EquipmentID", SqlDbType.Int).Value = equipment.ID;
                                cmd.Parameters.Add("@LostQuantity", SqlDbType.Int).Value = loan.LostQuantity;
                                cmd.Parameters.Add("@ReturnedQuantity", SqlDbType.Int).Value = returnedQuantity;

                                if (cmd.ExecuteNonQuery() == 0)
                                    throw new InvalidOperationException("Equipment inventory could not be updated.");
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
                throw SqlErrorMapper.Map(ex, "Mark loan as lost");
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

        public static DataTable GetDailyLoanStatistics(DateTime StartDate, DateTime EndDate)
        {
            var dtDailyStatics = new DataTable();

            string query = @"
SELECT
    CAST(LoanedAt AS DATE) AS LoanDate,
    COUNT(*) AS TotalLoans
FROM Loans
WHERE LoanedAt >= @StartDate
  AND LoanedAt < @EndDate
GROUP BY CAST(LoanedAt AS DATE)
ORDER BY LoanDate;";

            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                using (var cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                    cmd.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                    SqlDataReader reader = cmd.ExecuteReader();

                    dtDailyStatics.Load(reader);
                }
            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Get Daily Loan Statistics");
            }

            return dtDailyStatics;
        }

        public static bool hasUnpaidfee(int BorrowerID)
        {
            bool Has = false;

            string query = @"select 1 as HasUnpaidFine from Loans
                        where BorrowerID=@BorrowerID and FinePaid =0;";

            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                using (var cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.Add("@BorrowerID", SqlDbType.Int).Value = BorrowerID;

                    var reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        Has = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Check if borrower has unpaid fee.");
            }

            return Has;
        }

        private static void AddMoneyParameter(SqlCommand cmd, string name, decimal value)
        {
            SqlParameter parameter = cmd.Parameters.Add(name, SqlDbType.Decimal);
            parameter.Precision = 18;
            parameter.Scale = 6;
            parameter.Value = value;
        }

        public static bool UpdateLoan(Loan loan) 
        {

            bool IsUpdated=false;

            string query = @"UPDATE [dbo].[Loans]
   SET [EquipmentID] = @EquipmentID
      ,[BorrowerID] = @BorrowerID
      ,[UserID] = @UserID
      ,[Quantity] = @Quantity
      ,[LoanedAt] = @LoanedAt
      ,[DueAt] = @DueAt
      ,[ReturnedAt] = @ReturnedAt
      ,[Status] =@Status
      ,[LateFee] =@LateFee
      ,[FinePaid]=@FinePaid
      ,[LostQuantity]=@LostQuantity
      ,[ReplacementFee]=@ReplacementFee
      ,[ReplacementPaid]=@ReplacementPaid
 WHERE ID=@ID;";

            try 
            {
                using (var connection=new SqlConnection(ConnectionString))
                using (var cmd =new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = loan.ID;
                    cmd.Parameters.Add("@EquipmentID", SqlDbType.Int).Value = loan.EquipmentID;
                    cmd.Parameters.Add("@BorrowerID", SqlDbType.Int).Value = loan.BorrowerID;
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = loan.UserID;
                    cmd.Parameters.Add("@Quantity", SqlDbType.Int).Value = loan.Quantity;
                    cmd.Parameters.Add("@LoanedAt", SqlDbType.DateTime).Value = loan.LoanedAt;
                    cmd.Parameters.Add("@DueAt", SqlDbType.DateTime).Value = loan.DueAt;
                    cmd.Parameters.Add("@Status", SqlDbType.VarChar, 25).Value = loan.Status;

                    SqlParameter lateFeeParameter =
                        cmd.Parameters.Add("@LateFee", SqlDbType.Decimal);
                    lateFeeParameter.Precision = 10;
                    lateFeeParameter.Scale = 2;
                    lateFeeParameter.Value = loan.LateFee;

                    cmd.Parameters.Add("@ReturnedAt", SqlDbType.DateTime).Value =
                        loan.ReturnedAt.HasValue
                            ? (object)loan.ReturnedAt.Value
                            : DBNull.Value;

                    cmd.Parameters.Add("@FinePaid", SqlDbType.Bit).Value =
                        loan.FinePaid.HasValue
                            ? (object)loan.FinePaid.Value
                            : DBNull.Value;
                    cmd.Parameters.Add("@LostQuantity", SqlDbType.Int).Value = loan.LostQuantity;
                    AddMoneyParameter(cmd, "@ReplacementFee", loan.ReplacementFee);
                    cmd.Parameters.Add("@ReplacementPaid", SqlDbType.Bit).Value =
                        loan.ReplacementPaid.HasValue
                            ? (object)loan.ReplacementPaid.Value
                            : DBNull.Value;

                    int AAffectedRows = cmd.ExecuteNonQuery();

                    if (AAffectedRows > 0)
                        IsUpdated = true;
                }
                
            }
            catch(SqlException ex) 
            {
                throw SqlErrorMapper.Map(ex, "Update loan");
            }

            return IsUpdated;



        }
    }
}