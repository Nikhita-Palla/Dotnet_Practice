﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Models
{
    public class ProductRepository:IProductRepository
    {
        public ProductRepository()
        {
            
        }
        List<Product> IProductRepository.GetAll()
        {
            return new List<Product>(){
                new Product { Id = 1, Name = "Product1", Cost = "10" },
                new Product { Id = 2, Name = "Product2", Cost = "30" },
                new Product { Id = 3, Name = "Product3", Cost = "90" },
                new Product { Id = 4, Name = "Product4", Cost = "100" },
            };
        }
    }
}