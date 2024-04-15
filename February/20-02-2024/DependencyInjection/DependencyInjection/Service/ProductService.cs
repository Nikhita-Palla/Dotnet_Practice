using DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Service
{
    public class ProductService:IService
    {
        private IProductRepository _productRepository;

        public ProductService() 
        {
            _productRepository = DependencyResolver.Resolve<IProductRepository>();
        }

       
       

        IEnumerable<Product> IService.GetAllProducts()
        {
            return _productRepository.GetAll();
            
        }
    }
}