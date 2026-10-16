namespace LoanDesk.Models
{
    public class Borrower
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public string Passport { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }
    }
}