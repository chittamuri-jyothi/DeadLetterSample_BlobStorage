namespace AzureBlobStorage_DeadLettterEnh.Services
{
    public interface IContainerService
    {
        Task<List<string>> GetAllContainersAnsBlobs();
        Task<List<string>> GetAllContainers();
    }
}
