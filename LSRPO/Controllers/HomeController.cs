using LSRPO.Core.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LSRPO.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = $"{UserConstant.Roles.Administrator},{UserConstant.Roles.Operator}")]
        public IActionResult Messages()
        {
            return View();
        }

        [Authorize(Roles = $"{UserConstant.Roles.Administrator},{UserConstant.Roles.Operator}")]
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}