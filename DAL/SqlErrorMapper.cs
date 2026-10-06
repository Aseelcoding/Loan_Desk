using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class SqlErrorMapper
    {
        public static Exception Map(SqlException ex, string action)
        {
            switch (ex.Number)
            {
                case 2627: // unique constraint
                case 2601: // duplicate key
                    return new LoanDesk.Models.Exceptions.BusinessRuleException(
                    "This record already exists. A value that must be unique is already used.", ex);
                case 547: // foreign key / check constraint
                    return new LoanDesk.Models.Exceptions.BusinessRuleException(
                    "This operation conflicts with a data rule or with related records " +
                    "(for example the item is linked to other data).", ex);
                case 1205: // deadlock
                    return new LoanDesk.Models.Exceptions.DataAccessException(
                    "The database was busy and cancelled the operation. Please try again.", ex);
                case -2: // timeout
                    return new LoanDesk.Models.Exceptions.DataAccessException(
                    "The database took too long to respond. Please try again.", ex);
                case 53:
                case -1:
                case 2:
                case 233:
                case 10060:
                case 10061:
                case 4060:
                case 18456:
                    return new LoanDesk.Models.Exceptions.DataAccessException(
                    "Can't connect to the database. Check that SQL Server is running " +
                    "and the connection settings are correct.", ex);
                default:
                    return new LoanDesk.Models.Exceptions.DataAccessException(
                    "A database error occurred while trying to " + action + ".", ex);
            }
        }
    }
}
            
        
