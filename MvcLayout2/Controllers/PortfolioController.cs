using Microsoft.AspNetCore.Mvc;

namespace MvcLayout2.Controllers
{
    public class PortfolioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
