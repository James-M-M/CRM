using System.ComponentModel.DataAnnotations;

namespace CRM.Data.DTO
{
    public class AddStaffDto
    {
        public string UserId { get; set; }
        [Required(ErrorMessage = "Staff name is required")]
        public string StaffName { get; set; } = string.Empty;
        public List<Guid> ProjectIds { get; set; } = new List<Guid>();
        public string Address { get; set; } = string.Empty;
        public string PhoneNum { get; set; } = string.Empty;
        [EmailAddress(ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; } = string.Empty;
        public double Hours_Logged { get; set; }
    }
}
