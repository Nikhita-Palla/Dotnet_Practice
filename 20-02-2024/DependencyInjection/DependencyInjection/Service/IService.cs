using DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Service
{
    public interface IService
    {
        IEnumerable<Product> GetAllProducts();
    }
}