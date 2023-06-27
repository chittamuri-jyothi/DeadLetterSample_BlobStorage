using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace AzureBlobStorage_DeadLettterEnh.Services
{
    public class ContainerService : IContainerService
    {
        private readonly BlobServiceClient _blobClient;
        public ContainerService(BlobServiceClient blobClient)
        {
            _blobClient = blobClient;
        }
        public async Task<List<string>> GetAllContainers()
        {
            List<string> containerName = new();
            await foreach(BlobContainerItem blobContainerItem in _blobClient.GetBlobContainersAsync())
            {
                containerName.Add(blobContainerItem.Name);
            }
            return containerName;
        }

        public Task<List<string>> GetAllContainersAnsBlobs()
        {
            throw new NotImplementedException();
        }
    }
}
