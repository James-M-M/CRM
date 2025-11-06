namespace CRM.Data
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public double ChargedAmount { get; set; }
        public string Content { get; set; } = string.Empty;
        public string BusinessName { get; set; } = string.Empty;
        public int InvoiceNumber { get; set; }
        public DateTime Paymentdate { get; set; }
        public DateTime InvoiceDate { get; set; } = DateTime.UtcNow;
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public Guid StaffId { get; set; }
        public Staff Staff { get; set; }
        public Customer Customer { get; set; }
        public Guid CustomerId { get; set; }
        

    }
}
