using LoanDesk.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace DAL
{
    public class AuditLogDAL
    {
        private static readonly string ConnectionString = ConfigurationManager.ConnectionStrings["LoanDeskDB"].ConnectionString;


        public static DataTable GetAllAuditLog() 
        {
            var dtLogs=new DataTable("AuditLog");

            string query = @"SELECT [ID]
      ,[UserID]
      ,[ActionDate]
      ,[Action]
      ,[EntityType]
      ,[EntityID]
      ,[Details]
  FROM [dbo].[AuditLog];";

            try 
            {
                using (var connection =new SqlConnection (ConnectionString))
                using (var command = new SqlCommand(query, connection)) 
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    dtLogs.Load(reader);
                }

            }
            catch (SqlException ex) 
            {
                throw SqlErrorMapper.Map(ex, "Get All Audit Log");
            }

            return dtLogs;
        }

        public static bool AddNewAuditLog(AuditLog auditLog) 
        {
     
        bool IsAdded = false;

            string query = @"INSERT INTO [dbo].[AuditLog] 
                 ([UserID], [ActionDate], [Action], [EntityType], [EntityID], [Details]) 
                 VALUES (@UserID, @ActionDate, @Action, @EntityType, @EntityID, @Details);";

            try 
            {
                using (var connection =new SqlConnection(ConnectionString))
                using (var cmd=new SqlCommand(query, connection)) 
                {
                    connection.Open();
                    cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = auditLog.UserID;
                    cmd.Parameters.Add("@ActionDate", SqlDbType.DateTime).Value = auditLog.ActionDate;
                    cmd.Parameters.Add("@Action", SqlDbType.VarChar, 30).Value = auditLog.Action;
                    cmd.Parameters.Add("@EntityType", SqlDbType.VarChar, 30).Value = auditLog.EntityType;

                    cmd.Parameters.Add("@EntityID", SqlDbType.Int).Value = auditLog.EntityID;
                    cmd.Parameters.Add("@Details", SqlDbType.VarChar, 500).Value = auditLog.Details;

                    int AffectedRows = cmd.ExecuteNonQuery();

                    if(AffectedRows>0)
                        IsAdded= true;

                }

            }
            catch(SqlException ex) 
            {
               throw SqlErrorMapper.Map(ex, "Add New Audit Log.");
            }
            return IsAdded;
        }

    }
}
