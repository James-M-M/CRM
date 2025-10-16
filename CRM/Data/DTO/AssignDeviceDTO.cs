using System.ComponentModel.DataAnnotations;

namespace CRM.Data.DTO
{
    public class AssignDeviceDTO
    {
        public string SerialNumber { get; set; } = string.Empty;
        public string DeviceName { get; set; } = string.Empty;
        public DateTime AssignedDate { get; set; } = DateTime.UtcNow;
        public DateTime? ReturnDate { get; set; }

        [Required]
        public Guid DeviceTypeId { get; set; }

        public Guid? StaffId { get; set; }
    }
}
