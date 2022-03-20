using LSRPO.Core.Constants;
using LSRPO.Core.Contracts.User;
using LSRPO.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LSRPO.Controllers
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

        [Authorize(Roles = UserConstant.Roles.Administrator)]
        public async Task<IActionResult> ManageUsers()
        {
            var users = await userService.GetUsers();

            return Ok(users);
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