using Azure.Storage.Blobs;

namespace AzureBlobStorage_DeadLettterEnh.Services
{
    public class BlobService : IBlobService
    {
        private readonly BlobServiceClient _blobClient; 

        public BlobService(BlobServiceClient blobClient)
        {
            _blobClient = blobClient;
        }
        public async Task<List<string>> GetAllBlobs(string containerName)
        {
            string domain = "https://nuuichimportapp.blob.core.windows.net";
            string blobFullPath = "";
            BlobContainerClient blobContainerClient = _blobClient.GetBlobContainerClient(containerName);
            var blobs = blobContainerClient.GetBlobsAsync();
            var blobString = new List<string>();

            await foreach(var item in blobs)
            {
                blobFullPath = domain + "/" + containerName + "/" + item.Name;
                blobString.Add(blobFullPath);
            }
            return blobString;
        }

        public async Task<string> GetBlob(string blobName, string ContainerName)
        {
            BlobContainerClient blobContainerClient = _blobClient.GetBlobContainerClient(ContainerName);
            var blobClient = blobContainerClient.GetBlobClient(blobName);
            return blobClient.Uri.AbsoluteUri;
        }
    }
}
