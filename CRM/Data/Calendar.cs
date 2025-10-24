namespace CRM.Data
{
    public class Calendar
    {
        public Guid CalendarId { get; set; }
        public DateTime Start { get; set; }
        public DateTime end { get; set; }
        public string Text { get; set; } = string.Empty;
    }
}
