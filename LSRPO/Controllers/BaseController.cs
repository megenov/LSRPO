using LSRPO.Core.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LSRPO.Controllers
{
    [Authorize(Roles = $"{UserConstant.Roles.Administrator},{UserConstant.Roles.Operator}")]
    public class BaseController : Controller
    {
    }
}