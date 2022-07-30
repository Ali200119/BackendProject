using Microsoft.AspNetCore.Mvc;

namespace Allup.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }
    }
}
