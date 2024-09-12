using Microsoft.AspNetCore.Mvc;

namespace SneatFrontBack.Controllers
{
    public class LayoutsController : Controller
    {
        public IActionResult WithoutMenu()
        {
            return View();
        }
        public IActionResult WithoutNavbar()
        {
            return View();
        }
        public IActionResult Container()
        {
            return View();
        }
        public IActionResult FLuid()
        {
            return View();
        }
        public IActionResult Blank()
        {
            return View();
        }
    }
}
