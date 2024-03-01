using DependencyInjection.Models;
using DependencyInjection.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace DependencyInjection.Controllers
{
    public class ProductController : Controller
    {
        private readonly IService _productService;

        public ProductController()
        {
            _productService=DependencyResolver.Resolve<IService>();
        }

        public ActionResult GetAll()
        {
            return Json(_productService.GetAllProducts(), JsonRequestBehavior.AllowGet);
        }
    }
}