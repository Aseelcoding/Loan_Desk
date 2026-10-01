using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanDesk.Models
{
    public class AuditLog
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public DateTime  ActionDate { get; set; }
        //Allowed only (Add,Update,Delete)
        public string Action { get; set; }
        //Allowed only (Users,Borrowers,Equipment,Loans)
        public string EntityType { get; set; }
        public int EntityID { get; set; }
        public string Details {get; set;}

    }
}
