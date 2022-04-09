using LSRPO.Core.Constants;
using LSRPO.Core.Contracts.User;
using LSRPO.Core.Models.User;
using LSRPO.Infrastructure.Data.Models;
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
        private readonly IWebHostEnvironment webHostEnvironment;

        public UserController(RoleManager<AUTH_ROLE> roleManager, UserManager<AUTH_USER> userManager, SignInManager<AUTH_USER> signInManager, IUserService userService, IWebHostEnvironment webHostEnvironment)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.userService = userService;
            this.webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> UserProfile()
        {
            var user = await userManager.GetUserAsync(User);
            (var result, var model) = await userService.GetUserForProfileEdit(user.Id);

            if (!result)
            {
                TempData[MessageConstant.ErrorMessage] = "Невалиден потребител!";
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UserProfile(UserProfileViewModel model, IFormFile? image)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var result = true;
            var user = await userManager.GetUserAsync(User);
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

            if (result)
            {
                TempData[MessageConstant.SuccessMessage] = "Успешен запис!";
            }
            else
            {
                TempData[MessageConstant.ErrorMessage] = "Възникна грешка!";
            }

            if (nameEdit || image != null)
            {
                await signInManager.SignInAsync(user, isPersistent: false);
                return RedirectToAction("Index", "Home");
            }

            return RedirectToAction("Index", "Home");
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