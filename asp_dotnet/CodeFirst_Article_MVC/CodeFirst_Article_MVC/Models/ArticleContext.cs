using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Design;
using System.Configuration;

namespace CodeFirst_Article_MVC.Models
{
    public class ArticleContext 
    {
        public static string connection = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        public DbSet<ArticleModel> Articles { get; set; }
        public DbSet<UserModel> Authors { get; set; }
        public DbSet<CategoryModel> Categories { get; set; }

       

    }
}