namespace CRM.Data
{
    public class Sale
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime SaleDate { get; set; }
        
    }
}
