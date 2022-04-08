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
        private readonly IWebHostEnvironment webHostEnvironment;

        public UserController(RoleManager<AUTH_ROLE> roleManager, UserManager<AUTH_USER> userManager, IUserService userService, IWebHostEnvironment webHostEnvironment)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.userService = userService;
            this.webHostEnvironment = webHostEnvironment;
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
                var role = await userManager.GetRolesAsync(user);
                roles[item.Id] = role.FirstOrDefault();
            }

            ViewBag.Roles = roles;

            return View(users);
        }

        public async Task<IActionResult> EditProfile(int id)
        {
            var model = await userService.GetUserForProfileEdit(id);
            var user = await userManager.FindByIdAsync(id.ToString());

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

            var result = true;
            var user = await userManager.FindByIdAsync(model.Id.ToString());
            (bool nameEdit, string error) = await userService.UpdateName(model);

            if (nameEdit)
            {
                var newClaim = new Claim(ClaimConstant.FullName, model.FullName);
                var userClaims = await userManager.GetClaimsAsync(user);
                var claim = userClaims.FirstOrDefault(f => f.Type == ClaimConstant.FullName);

                if (claim != null)
                {
                    try
                    {
                        await userManager.ReplaceClaimAsync(user, claim, newClaim);
                    }
                    catch (Exception)
                    {
                        error = "Възникна грешка!";
                        result = false;
                    }
                }

                else
                {
                    try
                    {
                        await userManager.AddClaimAsync(user, newClaim);
                    }
                    catch (Exception)
                    {
                        error = "Възникна грешка!";
                        result = false;
                    }
                }
            }

            if (image != null)
            {
                string detailPath = Path.Combine(@"\img", image.FileName);
                using (var stream = new FileStream(webHostEnvironment.WebRootPath + detailPath, FileMode.Create))
                {
                    await image.CopyToAsync(stream);
                }

                user.IMAGE_URL = image.FileName;
                var newClaim = new Claim(ClaimConstant.ImageUrl, image.FileName);
                var userClaims = await userManager.GetClaimsAsync(user);
                var claim = userClaims.FirstOrDefault(f => f.Type == ClaimConstant.ImageUrl);

                if (claim != null)
                {
                    try
                    {
                        await userManager.UpdateAsync(user);
                        await userManager.ReplaceClaimAsync(user, claim, newClaim);
                    }
                    catch (Exception)
                    {
                        error = "Възникна грешка!";
                        result = false;
                    }
                }

                else
                {
                    try
                    {
                        await userManager.AddClaimAsync(user, newClaim);
                    }
                    catch (Exception)
                    {
                        error = "Възникна грешка!";
                        result = false;
                    }
                }
            }

            if (model.RoleName != null)
            {
                var userRoles = await userManager.GetRolesAsync(user);
                if (userRoles.Count > 0)
                {
                    try
                    {
                        await userManager.RemoveFromRolesAsync(user, userRoles);
                        await userManager.AddToRoleAsync(user, model.RoleName);
                    }
                    catch (Exception)
                    {
                        error = "Възникна грешка!";
                        result = false;
                    }
                }

                else
                {
                    try
                    {
                        await userManager.AddToRoleAsync(user, model.RoleName);
                    }
                    catch (Exception)
                    {
                        error = "Възникна грешка!";
                        result = false;
                    }
                }
            }

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешен запис!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
            }

            return RedirectToAction(nameof(ManageUsers));
        }

        public IActionResult ChangePassword(int id)
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

        [HttpPost]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var error = string.Empty;
            var user = await userManager.FindByIdAsync(id.ToString());
            //result = await userService.DeleteUserPin(id);

            var hasPin = await userService.HasPinCode(id);
            (var hasGroup, var groups) = await userService.HasGroup(id);

            if (hasPin && hasGroup)
            {
                error = $"Потребител {user.USR_FULLNAME} има ПИН код и е свързан към: {string.Join(", ", groups)}";
            }

            else if (hasPin)
            {
                error = $"Потребител {user.USR_FULLNAME} има ПИН код";
            }

            else if (hasGroup)
            {
                error = $"Потребител {user.USR_FULLNAME} е свързан към: {string.Join(", ", groups)}";
            }

            else
            {
                try
                {
                    await userManager.DeleteAsync(user);
                }
                catch (Exception)
                {
                    error = "Възникна грешка!";
                }
            }

            if (error == string.Empty)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешено изтриване!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = error;
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
                return RedirectToAction(nameof(ChangePin), new { id = model.UserId });
            }

            return RedirectToAction(nameof(PinCodes));
        }

        [HttpPost]
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