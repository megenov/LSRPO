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

            var status = await notifyStatusService.GetProcess(id);
            var processString = $"Група - {status.GroupName}, Потребител - {status.UserName}, Пулт - {status.PultName}, Тип - {status.ProccesTypeName}, Начало - {status.StartDate}, Край - {status.EndDate}, {status.FlagName}";

            ViewBag.Status = status;
            ViewBag.ProcessString = processString;

            return View(process);
        }

        public async Task<IActionResult> ProcessListAll()
        {
            var processAll = await notifyStatusService.GetProcessAll();

            return View(processAll);
        }
    }
}