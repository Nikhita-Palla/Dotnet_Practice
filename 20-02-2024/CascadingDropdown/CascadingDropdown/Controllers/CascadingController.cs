using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CascadingDropdown.Models;

namespace CascadingDropdown.Controllers
{
    public class CascadingController : Controller
    {
        // GET: Cascading
        public ActionResult Index()
        {
            return View();
        }
        public List<Country> GetCountryList() 
        { 
            
        }
    }
}