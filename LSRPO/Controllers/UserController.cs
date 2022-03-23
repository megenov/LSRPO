using LSRPO.Core.Constants;
using LSRPO.Core.Contracts.User;
using LSRPO.Core.Models.User;
using LSRPO.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace LSRPO.Controllers
{
    public class UserController : BaseController
    {
        private readonly RoleManager<AUTH_ROLE> roleManager;
        private readonly UserManager<AUTH_USER> userManager;
        private readonly SignInManager<AUTH_USER> signInManager;
        private readonly IUserService userService;

        public UserController(RoleManager<AUTH_ROLE> roleManager, UserManager<AUTH_USER> userManager, SignInManager<AUTH_USER> signInManager, IUserService userService)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> UserProfile()
        {
            var user = await userManager.GetUserAsync(User);
            var model = await userService.GetUserForProfileEdit(user.Id);
            ViewBag.Roles = await userManager.GetRolesAsync(user);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UserProfile(UserProfileViewModel model, IFormFile? image)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            (bool result, bool nameEdit, bool imageEdit) = await userService.UpdateUser(model, image);

            var user = await userManager.GetUserAsync(User);

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

            if (nameEdit || imageEdit)
            {
                await signInManager.SignInAsync(user, isPersistent: false);
                return Redirect("/");
            }

            return Redirect("/");
        }

        //[Authorize(Roles = UserConstant.Roles.Administrator)]
        //public async Task<IActionResult> CreateRole()
        //{
        //    await roleManager.CreateAsync(new AUTH_ROLE()
        //    {
        //        Name = ""
        //    });

        //    return Ok();
        //}
    }
}