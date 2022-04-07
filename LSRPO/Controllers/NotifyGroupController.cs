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

        public async Task<IActionResult> EditGroupUsers(int id)
        {
            var groupName = await notifyGroupService.GetGroupName(id);
            var model = notifyGroupService.GetUsers(id);

            ViewBag.GroupId = id;
            ViewBag.GroupName = groupName;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditGroupUsers(EditGroupUsersViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            (bool result, string error) = await notifyGroupService.EditGroupUsers(model);
            var groupName = await notifyGroupService.GetGroupName(model.GroupId);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = $"Успешно редактирани потребители в {groupName}!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(EditGroupUsers), new { id = model.GroupId });
        }

        public async Task<IActionResult> ClearGroupUsers(int id)
        {
            (bool result, string error) = await notifyGroupService.ClearGroupUsers(id);
            var groupName = await notifyGroupService.GetGroupName(id);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = $"Успешно изчистени потребители от {groupName}!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(EditGroupUsers), new { id = id });
        }

        public async Task<IActionResult> EditGroupObjects(int id)
        {
            var groupName = await notifyGroupService.GetGroupName(id);
            var groupFlag = await notifyGroupService.GetGroupFlag(id);
            var model = await notifyGroupService.GetObjects(id);

            if (User.IsInRole(UserConstant.Roles.Operator) && (!groupFlag ?? false))
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            ViewBag.GroupId = id;
            ViewBag.GroupName = groupName;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditGroupObjects(EditGroupObjectsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            (bool result, string error) = await notifyGroupService.EditGroupObjects(model);
            var groupName = await notifyGroupService.GetGroupName(model.GroupId);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = $"Успешно редактирани обекти в {groupName}!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(EditGroupObjects), new { id = model.GroupId });
        }

        public async Task<IActionResult> ClearGroupObjects(int id)
        {
            (bool result, string error) = await notifyGroupService.ClearGroupObjects(id);
            var groupName = await notifyGroupService.GetGroupName(id);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = $"Успешно изчистени обекти от {groupName}!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(EditGroupObjects), new { id = id });
        }
    }
}