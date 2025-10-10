namespace CRM.Data
{
    public class DeviceType
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty; // Laptop, Desktop, Tablet, Phone
        public string Description { get; set; } = string.Empty; // Description of the device type
    }
}
