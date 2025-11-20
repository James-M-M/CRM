using System.ComponentModel.DataAnnotations;

namespace CRM.Data
{
    public class Customer
    {
        public Guid CustomerId { get; set; }

        [Required(ErrorMessage = "Customer name is required")]
        public string Name { get; set; } = string.Empty;

        public string PhoneContact { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string EmailContact { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public string UserID { get; set; } = string.Empty;

        public ApplicationUser User { get; set; }

        public ICollection<Project> Projects { get; set; } = new List<Project>();
    }
}
