using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanDesk.Models
{
    internal class Borrower
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Passport { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }

    }
}
