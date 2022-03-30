using LSRPO.Core.Constants;
using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyProcess;
using Microsoft.AspNetCore.Mvc;

namespace LSRPO.Controllers
{
    public class NotifyProcessController : BaseController
    {
        private readonly INotifyProcessService notifyProcessService;

        public NotifyProcessController(INotifyProcessService notifyProcessService)
        {
            this.notifyProcessService = notifyProcessService;
        }

        public async Task<IActionResult> ProcessTypeList()
        {
            var processTypes = await notifyProcessService.GetProcessTypes();

            return View(processTypes);
        }

        public IActionResult AddNewProcessType()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewProcessType(AddProcessTypeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            (bool result, string error) = await notifyProcessService.AddProcessType(model);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешно добавен тип процес на оповестяване!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(ProcessTypeList));
        }

        public async Task<IActionResult> EditProcessType(int id)
        {
            var model = await notifyProcessService.GetProcessTypeForEdit(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditProcessType(EditProcessTypeViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            (bool result, string error) = await notifyProcessService.EditProcessType(model);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешно редактиран тип процес на оповестяване!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(ProcessTypeList));
        }

        public async Task<IActionResult> ProcessList()
        {
            var process = await notifyProcessService.GetProcess();

            return View(process);
        }

        [HttpPost]
        public async Task<IActionResult> EndProcess(int id)
        {
            (bool result, string error) = await notifyProcessService.EndProcess(id);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешено прекратен процес!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(ProcessList));
        }
    }
}