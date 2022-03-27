using LSRPO.Core.Constants;
using LSRPO.Core.Contracts.User;
using LSRPO.Core.Models.User;
using LSRPO.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace LSRPO.Areas.Admin.Controllers
{
    public class UserController : BaseController
    {
        private readonly RoleManager<AUTH_ROLE> roleManager;
        private readonly UserManager<AUTH_USER> userManager;
        private readonly IUserService userService;

        public UserController(RoleManager<AUTH_ROLE> roleManager, UserManager<AUTH_USER> userManager, IUserService userService)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ManageUsers()
        {
            var users = await userService.GetUsers();

            Dictionary<int, string> roles = new Dictionary<int, string>();

            foreach (var item in users)
            {
                var user = await userManager.FindByIdAsync(item.Id.ToString());
                IList<string> rolesList = await userManager.GetRolesAsync(user);
                roles[item.Id] = rolesList.FirstOrDefault();
            }

            ViewBag.Roles = roles;

            return View(users);
        }

        public async Task<IActionResult> EditProfile(int id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            var model = await userService.GetUserForProfileEdit(id);
            ViewBag.Roles = userManager.GetRolesAsync(user).Result;
            ViewBag.RoleItems = roleManager.Roles
                .ToList()
                .Select(s => new SelectListItem()
                {
                    Text = s.Name,
                    Value = s.Name,
                    Selected = userManager.IsInRoleAsync(user, s.Name).Result
                }).ToList();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditProfile(UserProfileViewModel model, IFormFile? image)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            (bool result, bool nameEdit, bool imageEdit) = await userService.UpdateUser(model, image);

            var user = await userManager.FindByIdAsync(model.Id.ToString());

            if (nameEdit)
            {
                var newClaim = new Claim(ClaimConstant.FullName, model.FullName);
                var userClaims = await userManager.GetClaimsAsync(user);
                var claim = userClaims.First(a => a.Type == ClaimConstant.FullName);
                await userManager.ReplaceClaimAsync(user, claim, newClaim);
            }

            if (imageEdit)
            {
                var newClaim = new Claim(ClaimConstant.ImageUrl, image.FileName);
                var userClaims = await userManager.GetClaimsAsync(user);
                var claim = userClaims.First(a => a.Type == ClaimConstant.ImageUrl);
                await userManager.ReplaceClaimAsync(user, claim, newClaim);
            }

            if (model.RoleName != null)
            {
                var userRoles = await userManager.GetRolesAsync(user);
                if (userRoles.Count > 0)
                {
                    await userManager.RemoveFromRolesAsync(user, userRoles);
                }
                await userManager.AddToRoleAsync(user, model.RoleName);
            }

            if (result)
            {
                //ViewData[MessageConstant.SuccessMessage] = "Успешен запис!";
                TempData[MessageConstant.SuccessMessage] = "Успешен запис!";
            }
            else
            {
                //ViewData[MessageConstant.ErrorMessage] = "Възникна грешка!";
                TempData[MessageConstant.ErrorMessage] = "Възникна грешка!";
            }

            return RedirectToAction(nameof(ManageUsers));
        }

        public async Task<IActionResult> ChangePassword(int id)
        {
            ViewBag.Id = id;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await userManager.FindByIdAsync(model.Id.ToString());
            var token = await userManager.GeneratePasswordResetTokenAsync(user);
            var result = await userManager.ResetPasswordAsync(user, token, model.ConfirmPassword);

            if (result.Succeeded)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешен запис!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = "Възникна грешка!";
            }

            return RedirectToAction(nameof(EditProfile), new { id = model.Id });
        }

        public async Task<IActionResult> DeleteUser(int id)
        {
            bool result = false;
            var user = await userManager.FindByIdAsync(id.ToString());
            result = await userService.DeleteUserPin(id);

            try
            {
                await userManager.DeleteAsync(user);
                result = true;
            }
            catch (Exception)
            {
                result = false;
            }

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешено изтриване!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = "Възникна грешка!";
            }

            return RedirectToAction(nameof(ManageUsers));
        }

        public async Task<IActionResult> PinCodes()
        {
            var userPins = await userService.GetPinCodes();

            return View(userPins);
        }

        public async Task<IActionResult> ChangePin(int id)
        {
            var model = await userService.GetPinCode(id); 

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ChangePin(ChangePinViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            (bool result, string error) = await userService.ChangePin(model);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешна промяна на ПИН код!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(PinCodes));
        }

        public async Task<IActionResult> DeletePin(int id)
        {
            (bool result, string error) = await userService.DeletePinCode(id);

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешено изтриване!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(PinCodes));
        }
    }
}