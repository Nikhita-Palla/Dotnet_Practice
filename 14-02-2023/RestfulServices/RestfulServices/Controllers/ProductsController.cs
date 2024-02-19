using RestfulServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.Http;

namespace RestfulServices.Controllers
{
    public class ProductsController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1", Price = 10.99m },
            new Product { Id = 2, Name = "Product 2", Price = 20.99m },
            new Product { Id = 3, Name = "Product 2", Price = 20.99m },
            new Product { Id = 4, Name = "Product 2", Price = 20.99m },
            new Product { Id = 5, Name = "Product 2", Price = 20.99m },
            new Product { Id = 6, Name = "Product 2", Price = 20.99m }
        };
        // GET: Products
        public IHttpActionResult Get()
        {
            return Ok(products);
        }

    }
}
