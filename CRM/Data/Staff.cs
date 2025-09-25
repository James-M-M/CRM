namespace CRM.Data
{
    public class Staff
    {
        public Guid StaffId { get; set; }
        public string UserID { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Project> AssignedProjects { get; set; } = new List<Project>();
    }
}
