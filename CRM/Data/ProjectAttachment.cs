using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Data
{
    public class ProjectAttachment
    {
        [Key]
        public Guid AttachmentId { get; set; }
        public string FileName { get; set; } = string.Empty;
        public string BlobUrl { get; set; } = string.Empty;
        public string ContentType { get; set; } = string.Empty;
        public DateTime UploadedAt { get; set; }
        public Guid? ProjectId { get; set; }
        public Project Project { get; set; }
        public Guid? CustomerInteractionsId { get; set; }
        public CustomerInteractions CustomerInteractions { get; set; }
    }
}
