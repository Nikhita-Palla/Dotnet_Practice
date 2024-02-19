using RestFul.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace RestFul.Controllers
{
    public class ProductController : ApiController
    {
        private static List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Product 1" },
            new Product { Id = 2, Name = "Product 2" },
            new Product { Id = 3, Name = "Product 3" }
        };
        public IEnumerable<Product> Get()
        {
            return products;
        }

        public Product Get(int id)
        {
            var row = products.FirstOrDefault(p => p.Id == id);
            return row;
        }

        public void Post([FromBody] Product product)
        {
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            products.Add(product);
        }
        public void Put(int id, [FromBody] Product updatedProduct)
        {
            if (updatedProduct == null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            int index = products.FindIndex(p => p.Id == id);
            if (index != -1)
            {
                products[index] = updatedProduct;
            }
            else
            {
                products.Add(updatedProduct);
            }
        }

        public void Patch(int id, [FromBody] Product updatedProduct)
        {
            if (updatedProduct == null)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            int index = products.FindIndex(p => p.Id == id);
            if (index != -1)
            {
                products[index] = updatedProduct;
            }
           
        }

        public void Delete(int id)
        {
            var productToRemove = products.FirstOrDefault(p => p.Id == id);
            if (productToRemove != null)
            {
                products.Remove(productToRemove);
            }
            else
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

    }
}
