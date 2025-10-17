namespace CRM.Data
{
    public class CustomerInteractions
    {
        public Guid Id { get; set; }
        public DateTime InteractionDate { get; set; }= DateTime.UtcNow;
        public string Comments { get; set; } = string.Empty;
        public ICollection<ProjectAttachment> Attachments { get; set; } = new List<ProjectAttachment>();
        public Guid ProjectId { get; set; }
        public Project Project { get; set; }
        public Guid StaffId { get; set; }
        public Staff Staff { get; set; }
    }
}
