using Microsoft.AspNetCore.Mvc;

namespace cs.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}