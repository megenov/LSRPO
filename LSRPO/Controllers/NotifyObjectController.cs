using LSRPO.Core.Constants;
using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyObject;
using Microsoft.AspNetCore.Mvc;

namespace LSRPO.Controllers
{
    public class NotifyObjectController : BaseController
    {
        private readonly INotifyObjectService notifyObjectService;

        public NotifyObjectController(INotifyObjectService notifyObjectService)
        {
            this.notifyObjectService = notifyObjectService;
        }

        public async Task<IActionResult> NotifyObjectList()
        {
            var notifyObjetcs = await notifyObjectService.GetObjects();

            return View(notifyObjetcs);
        }

        public async Task<IActionResult> AddNewObject()
        {
            var types = await notifyObjectService.GetTypes();
            ViewBag.Types = types;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewObject(AddObjectViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            (bool result, string error) = await notifyObjectService.AddObject(model);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешно добавен обект за оповестяване!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(NotifyObjectList));
        }


        public async Task<IActionResult> EditObject(int id)
        {
            (var model, var types) = await notifyObjectService.GetObjectForEdit(id);
            ViewBag.Types = types;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditObject(EditObjectViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            (bool result, string error) = await notifyObjectService.EditObject(model);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешно редактиран обект за оповестяване!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(NotifyObjectList));
        }

        public async Task<IActionResult> DeleteObject(int id)
        {
            (bool result, string error) = await notifyObjectService.DeleteObject(id);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешено изтриване!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(NotifyObjectList));
        }
    }
}