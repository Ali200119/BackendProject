using Microsoft.AspNetCore.Mvc;

namespace Allup.Areas.AdminPanel.Controllers
{
    [Area(nameof(AdminPanel))]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}