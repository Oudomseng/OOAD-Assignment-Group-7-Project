namespace LMSWebAPIProject.Models
{
    public class Overdue
    {
        public int Id { get; set; }
        public string Borrower { get; set; }
        public DateTime OverdueTime { get; set; }
        public decimal PaymentPerHour { get; set; }
        public decimal TotalPayments { get; set; }
        public decimal TenderedAmount { get; set; }
        public string Change { get; set; }
    }
}
