using Microsoft.EntityFrameworkCore;
using System;

namespace CoreWebApp.Models
{
    public class ArticleContext: DbContext
    {
        public ArticleContext(DbContextOptions<ArticleContext> options) : base(options)
        {
        }

        public DbSet<ArticleModel> Articles { get; set; }
    }
}
