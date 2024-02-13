using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst_Article_MVC.Models
{
    public class CategoryContext:DbContext
    {
        public static string connection = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public DbSet<CategoryModel> Categories {  get; set; }

        public CategoryContext() : base(connection) // Update with your connection string name
        {
        }

        public System.Data.Entity.DbSet<CodeFirst_Article_MVC.Models.ArticleModel> ArticleModels { get; set; }
    }
}