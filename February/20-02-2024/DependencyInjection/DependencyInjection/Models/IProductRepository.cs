using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Models
{
    public interface IProductRepository
    {
        List<Product> GetAll();
    }
}