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
            ViewBag.Types = notifyObjectService.GetTypes();

            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult> AddNewObject(AddObjectViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(model);
        //    }

        //    RedirectToAction(nameof(NotifyObjectList));
        //}


        //public async Task<IActionResult> EditObject(int id)
        //{
        //    var model = await userService.GetPinCode(id);

        //    return View(model);
        //}
    }
}