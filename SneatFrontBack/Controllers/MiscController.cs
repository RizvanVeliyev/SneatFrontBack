using Microsoft.AspNetCore.Mvc;

namespace SneatFrontBack.Controllers
{
    public class MiscController : Controller
    {
        public IActionResult Error()
        {
            return View();
        }
        public IActionResult Maintenance()
        {
            return View();
        }
    }
}
