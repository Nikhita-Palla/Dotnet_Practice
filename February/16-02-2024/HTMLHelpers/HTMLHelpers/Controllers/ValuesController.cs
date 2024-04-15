using HTMLHelpers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLHelpers.Controllers
{
    
    public class ValuesController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1" },
            new Product { Id = 2, Name = "Product 2" },
            new Product { Id = 3, Name = "Product 3" }
        };
        // GET: Values
        public ActionResult Index()
        {
            List<Product> values = products;
            ViewBag.Products = values; // Assign the list of products directly to ViewBag.Products
            return View();
        }
    }
}