namespace AzureBlobStorage_DeadLettterEnh.Services
{
    public interface IBlobService
    {
        Task<List<string>> GetAllBlobs(string containerName);
        Task<string> GetBlob(string blobName,string ContainerName);
    }
}
