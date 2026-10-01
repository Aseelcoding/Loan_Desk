using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanDesk.Models
{
    public class Loan
    {
        public int ID { get; set; }
        public int EquipmentID { get; set; }
        public int BorrowerID { get; set; }
        public int UserID { get; set; }
        public int Quantity { get; set; }
        public DateTime LoanedAt { get; set; }
        public DateTime DueAt { get; set; }
        public DateTime? ReturnedAt { get; set; }
        //Allowed (Active,Returned,Lost) only
        public string Status { get; set; }
        public decimal LateFee { get; set; }
        public bool? FinePaid { get; set; }


    }
}
