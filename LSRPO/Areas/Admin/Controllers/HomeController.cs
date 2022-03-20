using Microsoft.AspNetCore.Mvc;

namespace LSRPO.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}