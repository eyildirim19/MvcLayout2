using Microsoft.AspNetCore.Mvc;

namespace MvcLayout2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
