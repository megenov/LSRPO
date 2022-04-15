using LSRPO.Core.Constants;
using LSRPO.Core.Contracts;
using LSRPO.Core.Models.NotifyGroup;
using Microsoft.AspNetCore.Authorization;
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

        [Authorize(Roles = UserConstant.Roles.Administrator)]
        public async Task<IActionResult> EditGroup(int id)
        {
            var model = new EditGroupViewModel();

            try
            {
                model = await notifyGroupService.GetGroupForEdit(id);
            }
            catch (ArgumentException ex)
            {
                TempData[MessageConstant.ErrorMessage] = ex.Message;
                return RedirectToAction(nameof(NotifyGroupList));
            }

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = UserConstant.Roles.Administrator)]
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

        [Authorize(Roles = UserConstant.Roles.Administrator)]
        public async Task<IActionResult> EditGroupUsers(int id)
        {
            string? groupName = string.Empty;

            try
            {
                groupName = await notifyGroupService.GetGroupName(id);
            }
            catch (ArgumentException ex)
            {
                TempData[MessageConstant.ErrorMessage] = ex.Message;
                return RedirectToAction(nameof(NotifyGroupList));
            }

            var model = await notifyGroupService.GetUsers(id);

            ViewBag.GroupId = id;
            ViewBag.GroupName = groupName;

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = UserConstant.Roles.Administrator)]
        public async Task<IActionResult> EditGroupUsers(EditGroupUsersViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            string? groupName = string.Empty;

            try
            {
                groupName = await notifyGroupService.GetGroupName(model.GroupId);
            }
            catch (ArgumentException ex)
            {
                TempData[MessageConstant.ErrorMessage] = ex.Message;
                return RedirectToAction(nameof(NotifyGroupList));
            }

            (bool result, string error) = await notifyGroupService.EditGroupUsers(model);

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

        [Authorize(Roles = UserConstant.Roles.Administrator)]
        public async Task<IActionResult> ClearGroupUsers(int id)
        {
            string? groupName = string.Empty;

            try
            {
                groupName = await notifyGroupService.GetGroupName(id);
            }
            catch (ArgumentException ex)
            {
                TempData[MessageConstant.ErrorMessage] = ex.Message;
                return RedirectToAction(nameof(NotifyGroupList));
            }

            (bool result, string error) = await notifyGroupService.ClearGroupUsers(id);

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
            string? groupName = string.Empty;

            try
            {
                groupName = await notifyGroupService.GetGroupName(id);
            }
            catch (ArgumentException ex)
            {
                TempData[MessageConstant.ErrorMessage] = ex.Message;
                return RedirectToAction(nameof(NotifyGroupList));
            }

            var groupFlag = await notifyGroupService.GetGroupFlag(id);

            if (User.IsInRole(UserConstant.Roles.Operator) && (!groupFlag ?? false))
            {
                return RedirectToPage("/Account/AccessDenied", new { area = "Identity" });
            }

            var model = await notifyGroupService.GetObjects(id);

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

            string? groupName = string.Empty;

            try
            {
                groupName = await notifyGroupService.GetGroupName(model.GroupId);
            }
            catch (ArgumentException ex)
            {
                TempData[MessageConstant.ErrorMessage] = ex.Message;
                return RedirectToAction(nameof(NotifyGroupList));
            }

            (bool result, string error) = await notifyGroupService.EditGroupObjects(model);

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
            string? groupName = string.Empty;

            try
            {
                groupName = await notifyGroupService.GetGroupName(id);
            }
            catch (ArgumentException ex)
            {
                TempData[MessageConstant.ErrorMessage] = ex.Message;
                return RedirectToAction(nameof(NotifyGroupList));
            }

            (bool result, string error) = await notifyGroupService.ClearGroupObjects(id);

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