using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DIUnityFramework.Controllers
{
    public class ProductController : Controller
    {
        private IProductService productService;

        public ProductController(IProductService iproductservice)
        {
            productService = iproductservice;
        }

        public ActionResult GetAll()
        {
            return Json(productService.GetAll(), JsonRequestBehavior.AllowGet);
        }
    }
}