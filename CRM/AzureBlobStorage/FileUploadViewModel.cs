namespace CRM.AzureBlobStorage
{
    public class FileUploadViewModel
    {
        public string FileName { get; set; }
        public string FileStorageUrl { get; set; }
        public string ContentType { get; set; }
        public Guid Id { get; set; }
    }
}
