using AzureBlobStorage_DeadLettterEnh.Services;
using Microsoft.AspNetCore.Mvc;

namespace AzureBlobStorage_DeadLettterEnh.Controllers
{
    public class ContainerController : Controller
    {
      private readonly IContainerService _containerService;

     public ContainerController(IContainerService containerService)
        {
            _containerService = containerService;
        }
        public async Task<IActionResult> Index()
        {
            var allContainer = await _containerService.GetAllContainers();
            return View(allContainer);
        }
    }
}
