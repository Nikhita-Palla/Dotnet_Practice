using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Joins
{
    // Sample Product class
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryID { get; set; }
    }

    // Sample Category class
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

   

    internal class Program
    {
        static void Main(string[] args)
        {
            // Sample collections
            List<Product> products = new List<Product>()
            {
                new Product { ID = 1, Name = "Product A", CategoryID = 1 },
                new Product { ID = 2, Name = "Product B", CategoryID = 1 },
                new Product { ID = 3, Name = "Product C", CategoryID = 2 },
                new Product { ID = 4, Name = "Product D", CategoryID = 2 },
            };

            List<Category> categories = new List<Category>()
            {
                new Category { ID = 1, Name = "Category 1" },
                new Category { ID = 2, Name = "Category 2" },
            };

            //Inner Join
            var innerJoin = from product in products
                            join
                            category in categories
                            on product.CategoryID equals category.ID
                            select new { ProductId = product.ID, ProductName = product.Name, CategoryId = category.ID, CategoryName = category.Name };
            foreach(var val in innerJoin)
            {
                Console.WriteLine(val.ToString());
            }
            Console.WriteLine();

            //group join
            var groupJoin= from category in categories
                           join product in products on category.ID equals product.CategoryID into prodGroup
                           select new { CategoryName = category.Name, Products = prodGroup };

            foreach (var val in groupJoin)
            {
                Console.WriteLine($"Category: {val.CategoryName}");
                foreach (var product in val.Products)
                {
                    Console.WriteLine($"  Product: {product.Name}");
                }
            }
            Console.WriteLine();

            //left outer join
            var leftOuterJoinQuery =
                                    from category in categories
                                    join product in products on category.ID equals product.CategoryID into prodGroup
                                    from prod in prodGroup.DefaultIfEmpty()
                                    select new { CategoryName = category.Name, ProductName = prod?.Name };

            foreach (var val in leftOuterJoinQuery)
            {
               
                Console.WriteLine(val);
            }

            Console.WriteLine();

            var crossJoinQuery =
                                from category in categories
                                from product in products
                                select new { CategoryName = category.Name, ProductName = product.Name };
            foreach (var val in crossJoinQuery)
            {

                Console.WriteLine(val);
            }



        }
    }
}
