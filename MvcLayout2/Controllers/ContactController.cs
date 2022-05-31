using Microsoft.AspNetCore.Mvc;

namespace MvcLayout2.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
