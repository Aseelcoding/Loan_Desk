using DAL;
using LoanDesk.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AuditLogBLL
    {
        public static DataTable GetAllAuditLog() 
        {
            return AuditLogDAL.GetAllAuditLog();
        }
        public static bool AddNewAuditLog(AuditLog auditLog) 
        {
            return AuditLogDAL.AddNewAuditLog(auditLog);
        }
    }
}
