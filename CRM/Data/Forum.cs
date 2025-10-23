namespace CRM.Data
{
    public class Forum
    {
        public Guid Id { get;set; }
        public string Title { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;
        public string replies { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
