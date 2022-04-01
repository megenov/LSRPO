using LSRPO.Core.Constants;
using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyGroup;
using Microsoft.AspNetCore.Mvc;

namespace LSRPO.Controllers
{
    public class NotifyGroupController : BaseController
    {
        private readonly INotifyGroupService notifyGroupService;

        public NotifyGroupController(INotifyGroupService notifyGroupService)
        {
            this.notifyGroupService = notifyGroupService;
        }

        public async Task<IActionResult> NotifyGroupList()
        {
            var notifyGroups = await notifyGroupService.GetGroups();

            return View(notifyGroups);
        }

        public async Task<IActionResult> EditGroup(int id)
        {
            var model = await notifyGroupService.GetGroupForEdit(id);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditGroup(EditGroupViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            (bool result, string error) = await notifyGroupService.EditGroup(model);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешно редактирана група за оповестяване!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(NotifyGroupList));
        }

        public async Task<IActionResult> EditGroupUsers()
        {


            return View();
        }

        public async Task<IActionResult> EditGroupObjects(int id)
        {
            var groupName = await notifyGroupService.GetGroupName(id);
            var model = await notifyGroupService.GetObjects(id);

            ViewBag.GroupName = groupName;

            return View(model);
        }

        [HttpPost]
        public IActionResult EditGroupObjects(IEnumerable<EditGroupObjectsViewModel> model)
        {


            return RedirectToAction(nameof(NotifyGroupList));
        }
    }
}