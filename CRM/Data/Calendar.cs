using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Data
{
    public class Calendar
    {
        public Guid CalendarId { get; set; }
        public DateTime Start { get; set; }
        // Renamed to PascalCase so RadzenScheduler will find the end-time property
        [Column("end")]
        public DateTime End { get; set; }
        public string Text { get; set; } = string.Empty;
    }
}
