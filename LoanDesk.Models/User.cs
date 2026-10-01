using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanDesk.Models
{
    public class User
    {

        public int ID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        //Allowed roles (Admin,Staff) only.
        public string Role { get; set; }
        public bool IsActive {  get; set; }



    }
}
