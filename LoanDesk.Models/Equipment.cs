namespace LoanDesk.Models
{
    public class Equipment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int TotalQuantity { get; set; }
        public int AvailableQuantity { get; set; }
        public decimal DailyLateFee { get; set; }
        public decimal ReplacementCost { get; set; }
        public bool IsActive { get; set; }
    }
}