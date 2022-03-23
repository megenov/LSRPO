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

            return View(users);
        }

        public async Task<IActionResult> Roles(int id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());

            var model = new UserRolesViewModel()
            {
                UserId = user.Id,
                FullName = user.USR_FULLNAME
            };

            ViewBag.RoleItems = roleManager.Roles
                .ToList()
                .Select(s => new SelectListItem()
                {
                    Text = s.Name,
                    Value = s.Id.ToString(),
                    Selected = userManager.IsInRoleAsync(user, s.Name).Result
                }).ToList();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Roles(UserRolesViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("ManageUsers");
        }

        public async Task<IActionResult> EditProfile(int id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            var model = await userService.GetUserForProfileEdit(id);
            ViewBag.Roles = await userManager.GetRolesAsync(user);

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

            return RedirectToAction("EditProfile");
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

            return RedirectToAction("EditProfile", new { id = model.Id });
        }

        public async Task<IActionResult> CreateRole()
        {
            //await roleManager.CreateAsync(new AUTH_ROLE()
            //{
            //    Name = ""
            //});

            return Ok();
        }
    }
}