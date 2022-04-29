using LSRPO.Core.Constants;
using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyObject;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var positions = await notifyObjectService.GetPositions();

            if (!User.IsInRole(UserConstant.Roles.Administrator))
            {
                types = await notifyObjectService.GetOperatorTypes();
            }

            ViewBag.Types = types;
            ViewBag.Positions = positions;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddNewObject(AddObjectViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (User.IsInRole(UserConstant.Roles.Operator) && model.TypeId != 2)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            if (User.IsInRole(UserConstant.Roles.Operator) && model.Phone1 != null && model.Phone1.Length != 11)
            {
                TempData[MessageConstant.ErrorMessage] = "Невалиден номер на Тел. Обект / Мобилен 1";
                var types = await notifyObjectService.GetTypes();
                var positions = await notifyObjectService.GetPositions();
                if (!User.IsInRole(UserConstant.Roles.Administrator))
                {
                    types = await notifyObjectService.GetOperatorTypes();
                }
                ViewBag.Types = types;
                ViewBag.Positions = positions;
                return View(model);
            }

            if (model.Phone1 != null && model.Phone1.Length != 11 && model.TypeId == 2)
            {
                TempData[MessageConstant.ErrorMessage] = "Невалиден номер на Тел. Обект / Мобилен 1";
                var types = await notifyObjectService.GetTypes();
                var positions = await notifyObjectService.GetPositions();
                if (!User.IsInRole(UserConstant.Roles.Administrator))
                {
                    types = await notifyObjectService.GetOperatorTypes();
                }
                ViewBag.Types = types;
                ViewBag.Positions = positions;
                return View(model);
            }

            if (model.TypeId != 2 && model.PositionId != null)
            {
                TempData[MessageConstant.ErrorMessage] = "Невалиден Пост";
                var types = await notifyObjectService.GetTypes();
                var positions = await notifyObjectService.GetPositions();
                if (!User.IsInRole(UserConstant.Roles.Administrator))
                {
                    types = await notifyObjectService.GetOperatorTypes();
                }
                ViewBag.Types = types;
                ViewBag.Positions = positions;
                model.PositionId = null;

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
            EditObjectViewModel model = new EditObjectViewModel();
            IEnumerable<SelectListItem> types = new List<SelectListItem>();

            try
            {
                (model, types) = await notifyObjectService.GetObjectForEdit(id);
            }
            catch (ArgumentException ex)
            {
                TempData[MessageConstant.ErrorMessage] = ex.Message;
                return RedirectToAction(nameof(NotifyObjectList));
            }

            if (User.IsInRole(UserConstant.Roles.Operator) && model.TypeId != 2)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            var positions = await notifyObjectService.GetPositions();

            ViewBag.Types = types;
            ViewBag.Positions = positions;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditObject(EditObjectViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            if (User.IsInRole(UserConstant.Roles.Operator) && model.TypeId != 2)
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            if (User.IsInRole(UserConstant.Roles.Operator) && model.Phone1 != null && model.Phone1.Length != 11)
            {
                TempData[MessageConstant.ErrorMessage] = "Невалиден номер на Тел. Обект / Мобилен 1";
                var types = await notifyObjectService.GetTypes();
                var positions = await notifyObjectService.GetPositions();
                if (!User.IsInRole(UserConstant.Roles.Administrator))
                {
                    types = await notifyObjectService.GetOperatorTypes();
                }
                ViewBag.Types = types;
                ViewBag.Positions = positions;
                return View(model);
            }

            if (model.Phone1 != null && model.Phone1.Length != 11 && model.TypeId == 2)
            {
                TempData[MessageConstant.ErrorMessage] = "Невалиден номер на Тел. Обект / Мобилен 1";
                var types = await notifyObjectService.GetTypes();
                var positions = await notifyObjectService.GetPositions();
                if (!User.IsInRole(UserConstant.Roles.Administrator))
                {
                    types = await notifyObjectService.GetOperatorTypes();
                }
                ViewBag.Types = types;
                ViewBag.Positions = positions;
                return View(model);
            }

            if (model.TypeId != 2 && model.PositionId != null)
            {
                TempData[MessageConstant.ErrorMessage] = "Невалиден Пост";
                var types = await notifyObjectService.GetTypes();
                var positions = await notifyObjectService.GetPositions();
                if (!User.IsInRole(UserConstant.Roles.Administrator))
                {
                    types = await notifyObjectService.GetOperatorTypes();
                }
                ViewBag.Types = types;
                ViewBag.Positions = positions;
                model.PositionId = null;

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

        [HttpPost]
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

        [Authorize(Roles = UserConstant.Roles.Administrator)]
        public async Task<IActionResult> PultsList()
        {
            var pults = await notifyObjectService.GetPults();

            return View(pults);
        }

        [Authorize(Roles = UserConstant.Roles.Administrator)]
        public IActionResult AddNewPult()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = UserConstant.Roles.Administrator)]
        public async Task<IActionResult> AddNewPult(AddPultViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            (bool result, string error) = await notifyObjectService.AddPult(model);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешно добавен пулт за оповестяване!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(PultsList));
        }

        [Authorize(Roles = UserConstant.Roles.Administrator)]
        public async Task<IActionResult> EditPult(int id)
        {
            var model = new EditPultViewModel();

            try
            {
                model = await notifyObjectService.GetPultForEdit(id);
            }
            catch (ArgumentException ex)
            {
                TempData[MessageConstant.ErrorMessage] = ex.Message;
                return RedirectToAction(nameof(PultsList));
            }

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = UserConstant.Roles.Administrator)]
        public async Task<IActionResult> EditPult(EditPultViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            (bool result, string error) = await notifyObjectService.EditPult(model);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешно редактиран пулт за оповестяване!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(PultsList));
        }

        [HttpPost]
        [Authorize(Roles = UserConstant.Roles.Administrator)]
        public async Task<IActionResult> DeletePult(int id)
        {
            (bool result, string error) = await notifyObjectService.DeletePult(id);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешено изтриване!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(PultsList));
        }
    }
}