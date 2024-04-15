using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirst_Article_MVC.Models
{
    public class UserContext:DbContext
    {
        public static string connection = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        public DbSet<UserModel> Authors { get; set; }
        public UserContext() : base(connection) // Update with your connection string name
        {
        }

    }
}