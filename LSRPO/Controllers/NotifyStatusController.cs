using LSRPO.Core.Constants;
using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyStatus;
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
            IEnumerable<ProcessDetailsViewModel> process = new List<ProcessDetailsViewModel>();

            try
            {
                process = await notifyStatusService.GetProcessDetails(id);
            }
            catch (ArgumentException ex)
            {
                TempData[MessageConstant.ErrorMessage] = ex.Message;
                return RedirectToAction(nameof(ProcessListAll));
            }

            ViewBag.ProcessId = id;

            return View(process);
        }

        public async Task<IActionResult> ProcessListAll()
        {
            var processAll = await notifyStatusService.GetProcessAll();

            return View(processAll);
        }
    }
}