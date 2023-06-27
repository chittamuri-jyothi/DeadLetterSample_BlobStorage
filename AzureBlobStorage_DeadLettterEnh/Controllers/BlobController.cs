using AzureBlobStorage_DeadLettterEnh.Services;
using Microsoft.AspNetCore.Mvc;

namespace AzureBlobStorage_DeadLettterEnh.Controllers
{
    public class BlobController : Controller
    {
        private readonly IBlobService _blobService;

        public BlobController(IBlobService blobService)
        {
            _blobService = blobService;
        }


        [HttpGet]
        public async Task<IActionResult> Manage(string ContainerName)
        {
            var blobsObj = await _blobService.GetAllBlobs(ContainerName);
            return View(blobsObj);
        }
    }
}
