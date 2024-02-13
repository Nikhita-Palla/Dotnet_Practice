using CodeFirst_Article_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst_Article_MVC.Controllers
{
    public class ArticleController : Controller
    {
        ArticleContext articleContext=new ArticleContext();

        // GET: Article
        public ActionResult Index()
        {
            var data= articleContext.Articles.ToList();
            return View(data);
        }
    }
}