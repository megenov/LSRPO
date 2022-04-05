// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using LSRPO.Core.Constants;
using LSRPO.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace LSRPO.Areas.Identity.Pages.Account
{
    [Authorize(Roles = UserConstant.Roles.Administrator)]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<AUTH_USER> _signInManager;
        private readonly UserManager<AUTH_USER> _userManager;
        private readonly IUserStore<AUTH_USER> _userStore;
        private readonly IUserEmailStore<AUTH_USER> _emailStore;
        private readonly ILogger<RegisterModel> _logger;

        public RegisterModel(
            UserManager<AUTH_USER> userManager,
            IUserStore<AUTH_USER> userStore,
            SignInManager<AUTH_USER> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender)
        {
            _userManager = userManager;
            _userStore = userStore;
            _emailStore = GetEmailStore();
            _signInManager = signInManager;
            _logger = logger;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            ///// <summary>
            /////     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            /////     directly from your code. This API may change or be removed in future releases.
            ///// </summary>
            //[Required]
            //[EmailAddress]
            //[Display(Name = "Email")]
            //public string Email { get; set; }

            [Required(ErrorMessage = "Полето {0} е задължително")]
            [StringLength(100, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 4)]
            [Display(Name = "Име")]
            public string USR_FULLNAME { get; set; }

            [Required(ErrorMessage = "Полето {0} е задължително")]
            [Display(Name = "Потребителско име")]
            [StringLength(20, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 4)]
            [RegularExpression("^[a-zA-Z0-9]*$", ErrorMessage = "Позволени символи: Латински букви и цифри")]
            public string UserName { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Required(ErrorMessage = "Полето {0} е задължително")]
            [StringLength(100, ErrorMessage = "Полето {0} трябва да бъде между {2} и {1} символа.", MinimumLength = 4)]
            [DataType(DataType.Password)]
            [Display(Name = "Парола")]
            public string Password { get; set; }

            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [DataType(DataType.Password)]
            [Display(Name = "Потвърждаване на паролата")]
            [Compare("Password", ErrorMessage = "Паролите не съвпадат")]
            public string ConfirmPassword { get; set; }
        }


        public void OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl ??= Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = CreateUser();

                user.USR_FULLNAME = Input.USR_FULLNAME;
                user.USR_REG_DATE = DateTime.Now;
                user.IMAGE_URL = "user.png";

                await _userStore.SetUserNameAsync(user, Input.UserName, CancellationToken.None);
                await _emailStore.SetEmailAsync(user, $"{Input.UserName}@stk.local", CancellationToken.None);
                var result = await _userManager.CreateAsync(user, Input.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddClaimAsync(user, new Claim(ClaimConstant.FullName, user.USR_FULLNAME));
                    await _userManager.AddClaimAsync(user, new Claim(ClaimConstant.ImageUrl, user.IMAGE_URL));

                    _logger.LogInformation("User created a new account with password.");

                    var userId = await _userManager.GetUserIdAsync(user);

                    TempData[MessageConstant.SuccessMessage] = $"Успешно създаден потребител {Input.USR_FULLNAME}!";
                    return RedirectToAction("EditProfile", "User", new { id = userId, area = "Admin" });
                }
                //foreach (var error in result.Errors)
                //{
                //    ModelState.AddModelError(string.Empty, error.Description);
                //}
                ModelState.AddModelError(string.Empty, "Невалиден потребител");
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }

        private AUTH_USER CreateUser()
        {
            try
            {
                return Activator.CreateInstance<AUTH_USER>();
            }
            catch
            {
                throw new InvalidOperationException($"Can't create an instance of '{nameof(AUTH_USER)}'. " +
                    $"Ensure that '{nameof(AUTH_USER)}' is not an abstract class and has a parameterless constructor, or alternatively " +
                    $"override the register page in /Areas/Identity/Pages/Account/Register.cshtml");
            }
        }

        private IUserEmailStore<AUTH_USER> GetEmailStore()
        {
            if (!_userManager.SupportsUserEmail)
            {
                throw new NotSupportedException("The default UI requires a user store with email support.");
            }
            return (IUserEmailStore<AUTH_USER>)_userStore;
        }
    }
}