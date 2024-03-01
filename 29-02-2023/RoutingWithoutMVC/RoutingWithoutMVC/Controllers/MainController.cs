using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
