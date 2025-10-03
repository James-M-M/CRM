namespace CRM.Data
{
    public enum ProjectPriority
    {
        Low,
        Medium,
        High
    }

    public class Project
    {
        public Guid ProjectId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Staff> AssignedStaff { get; set; } = new List<Staff>();
        public ICollection<ProjectAttachment> Attachments { get; set; } = new List<ProjectAttachment>();
        public ProjectPriority Priority { get; set; } = ProjectPriority.Medium;
    }
}
