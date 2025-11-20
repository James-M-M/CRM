using System.ComponentModel.DataAnnotations;

namespace CRM.Data
{
    public class Staff
    {
        public Guid StaffId { get; set; }
        [Required]
        public string UserID { get; set; }
        

        [Required(ErrorMessage = "Customer name is required")]
        public string StaffName { get; set; }
        public ApplicationUser User { get; set; }
        public ICollection<Project> AssignedProjects { get; set; } = new List<Project>();
        public string Address { get; set; }
        public string PhoneNum { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        public double Hours_Logged { get; set; }
        public ICollection<CustomerInteractions> CustomerInteractions { get; set; } = new List<CustomerInteractions>();

    }
}
