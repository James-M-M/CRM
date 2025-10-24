namespace CRM.Data
{
    public class Reply
    {
        public Guid Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public Guid ForumId { get; set; }
        public Forum Forum { get; set; }
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
