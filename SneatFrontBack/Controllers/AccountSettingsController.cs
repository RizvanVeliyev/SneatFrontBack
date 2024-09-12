using Microsoft.AspNetCore.Mvc;

namespace SneatFrontBack.Controllers
{
    public class AccountSettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Nofications()
        {
            return View();
        }
        public IActionResult Connections()
        {
            return View();
        }
    }
}
