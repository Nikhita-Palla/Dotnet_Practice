using Microsoft.AspNetCore.Mvc;

namespace AttributeRouting.Controllers
{
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Index")]
        [Route("~/")]  // to not give error page when nothing in URL
        public IActionResult Index()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Details/{id}")]
        public IActionResult Details(int id)
        {
            return View(id);
        }
        
    }
}
