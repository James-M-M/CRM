namespace CRM.AzureBlobStorage.Interface
{
    public interface IBlobStorageService
    {
        Task<string> UploadFileToBlobAsync(string FileName, string contentType, Stream fileStream);
        Task<bool> DeleteFileToBlobAsync(string FileName);
    }
}
