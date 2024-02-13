using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst_Article_MVC.Models
{
    public class TagContext:DbContext
    {
        public static string connection = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public DbSet<TagModel> Tags { get; set; }

        public TagContext() : base(connection) // Update with your connection string name
        {
        }

    }
}