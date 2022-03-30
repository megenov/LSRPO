using LSRPO.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LSRPO.Controllers
{
    public class NotifyStatusController : BaseController
    {
        private readonly INotifyStatusService notifyStatusService;

        public NotifyStatusController(INotifyStatusService notifyStatusService)
        {
            this.notifyStatusService = notifyStatusService;
        }

        public async Task<IActionResult> ProcessDetails(int id)
        {
            var process = await notifyStatusService.GetProcessDetails(id);

            return View(process);
        }
    }
}