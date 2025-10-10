using System.ComponentModel.DataAnnotations;

namespace CRM.Data
{
    public class Device
    {
        public Guid Id { get; set; }
        public string SerialNumber { get; set; } = string.Empty;// APS2356XYZ-2023
        public Guid DeviceTypeId { get; set; } // Laptop, Desktop, Tablet, Phone
        public DeviceType DeviceType { get; set; }
        public string DeviceName { get; set; } = string.Empty;//Apple MacBook Pro, Dell XPS 13
        public DateTime AssignedDate { get; set; } = DateTime.UtcNow;
        public DateTime? ReturnDate { get; set; }
        public Guid? StaffId { get; set; }
        public Staff? Staff { get; set; }
    }
}
