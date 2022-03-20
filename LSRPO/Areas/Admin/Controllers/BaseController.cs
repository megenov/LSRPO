using LSRPO.Core.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LSRPO.Areas.Admin.Controllers
{
    [Authorize(Roles = UserConstant.Roles.Administrator)]
    [Area("Admin")]
    public class BaseController : Controller
    {
    }
}