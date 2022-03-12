using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LSRPO.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}