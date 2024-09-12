using Microsoft.AspNetCore.Mvc;

namespace SneatFrontBack.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
