namespace CRM.Data.DTO
{
    public class AddStaffDto
    {
        public string UserId { get; set; }
        public string StaffName { get; set; } = string.Empty;
        public List<Guid> ProjectIds { get; set; } = new List<Guid>();
        public string Address { get; set; } = string.Empty;
        public string PhoneNum { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}
