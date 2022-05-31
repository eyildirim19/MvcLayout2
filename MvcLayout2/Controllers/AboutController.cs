using Microsoft.AspNetCore.Mvc;

namespace MvcLayout2.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
