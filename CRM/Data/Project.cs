namespace CRM.Data
{
    public class Project
    {
        public Guid ProjectId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Details { get; set; } = string.Empty;
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public ICollection<Staff> AssignedStaff { get; set; } = new List<Staff>();



    }
}
