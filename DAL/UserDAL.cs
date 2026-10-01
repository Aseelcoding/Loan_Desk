using System.Configuration;
using System.Data.SqlClient;
using LoanDesk.Models;
namespace DAL
{
    public class UserDAL
    {
        private readonly string  ConnectionString = ConfigurationManager.ConnectionStrings["LoanDeskDB"].ConnectionString;


        public bool AddNewAdmin(User user) 
        {
            bool IsAdded = false;

          



            return IsAdded;

        }
    }
}
