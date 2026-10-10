using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using LoanDesk.Models;
namespace DAL
{
    public class EquipmentDAL
    {
        //catch (SqlException ex) 
        //{
        //    throw SqlErrorMapper.Map(ex, "Add New borrower");
        //}
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["LoanDeskDB"].ConnectionString;


        public static bool AddEquipment(Equipment NewEquipment) 
        {
            bool IsAdded = false;

            string query = @"INSERT INTO [dbo].[Equipment]
           ([Name]
           ,[TotalQuantity]
           ,[AvailableQuantity]
           ,[DailyLateFee]
           ,[ReplacementCost]
           ,[IsActive])
     VALUES
           (@Name
           ,@TotalQuantity
           ,@AvailableQuantity
           ,@DailyLateFee
           ,@ReplacementCost
           ,@IsActive
           );";

            try 
            {
                using (var connection = new SqlConnection (ConnectionString))
                using (var cmd=new SqlCommand(query, connection)) 
                {
                    connection.Open ();
                    cmd.Parameters.Add("@Name",SqlDbType.VarChar, 250).Value= NewEquipment.Name;
                    cmd.Parameters.Add("@TotalQuantity", SqlDbType.Int).Value = NewEquipment.TotalQuantity;
                    cmd.Parameters.Add("@AvailableQuantity", SqlDbType.Int).Value = NewEquipment.AvailableQuantity;
                    cmd.Parameters.Add("@DailyLateFee", SqlDbType.Decimal).Value = NewEquipment.DailyLateFee;
                    cmd.Parameters.Add("@ReplacementCost",SqlDbType.Decimal).Value= NewEquipment.ReplacementCost;
                    cmd.Parameters.Add("@IsActive", SqlDbType.Bit).Value = NewEquipment.IsActive;

                    int AffectedRows = cmd.ExecuteNonQuery() ;
                    if(AffectedRows>=1)
                        IsAdded= true;
                }

            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Add New borrower");
            }
            return IsAdded;
        }
        public static Equipment GetEquipmentByID(int EquipmentID) 
        {
            string query = @"SELECT [ID]
      ,[Name]
      ,[TotalQuantity]
      ,[AvailableQuantity]
      ,[DailyLateFee]
      ,[ReplacementCost]
      ,[IsActive]
  FROM [dbo].[Equipment]
  where ID=@EquipmentID;";

            try 
            {
                using (var connection =new SqlConnection(ConnectionString))
                using (var cmd=new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.Add("@EquipmentID",SqlDbType.Int).Value= EquipmentID;

                    using (SqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        if (!reader.Read())
                            return null;
                        return new Equipment
                        {
                            ID = EquipmentID,
                            Name = reader["Name"].ToString(),

                            TotalQuantity = (int)reader["TotalQuantity"],
                            AvailableQuantity= (int)reader["AvailableQuantity"],
                            DailyLateFee= (decimal)reader["DailyLateFee"],
                            ReplacementCost=(decimal)reader["ReplacementCost"],
                            IsActive=(bool)reader["IsActive"]
                        };

                    }
                }
            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Add New borrower");
            }
        }
        public static Equipment GetEquipmentByName(string EquipmentName) 
        {
            string query = @"SELECT [ID]
      ,[Name]
      ,[TotalQuantity]
      ,[AvailableQuantity]
      ,[DailyLateFee]
      ,[ReplacementCost]
      ,[IsActive]
  FROM [dbo].[Equipment]
  where Name=@Name;";

            try
            {
                using (var connection = new SqlConnection(ConnectionString))
                using (var cmd = new SqlCommand(query, connection))
                {
                    connection.Open();
                    cmd.Parameters.Add("@Name", SqlDbType.VarChar).Value = EquipmentName;

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                            return null;
                        int EQID;
                        int.TryParse(reader["ID"].ToString (), out EQID);
                        return new Equipment
                        {
                           
                            ID = EQID,
                            Name = reader["Name"].ToString(),

                            TotalQuantity = (int)reader["TotalQuantity"],
                            AvailableQuantity = (int)reader["AvailableQuantity"],
                            DailyLateFee = (decimal)reader["DailyLateFee"],
                            ReplacementCost = (decimal)reader["ReplacementCost"],
                            IsActive = (bool)reader["IsActive"]
                        };

                    }
                }
            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Add New borrower");
            }
        }
        public static DataTable GetEquipments() 
        {
            DataTable dtEq = new DataTable("Equipments");
            string query = @"SELECT [ID],
       [Name],
       [TotalQuantity],
       [AvailableQuantity],
       [DailyLateFee],
       [ReplacementCost],
       [IsActive]
FROM   [dbo].[Equipment];";


            try 
            {
                using (SqlConnection connection =new SqlConnection(ConnectionString))
                using (SqlCommand cmd =new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader()) 
                    {
                       dtEq.Load(reader);
                    }
                }

            }
            catch (SqlException ex)
            {
                throw SqlErrorMapper.Map(ex, "Add New borrower");
            }

            return dtEq;
        }

    }
}
