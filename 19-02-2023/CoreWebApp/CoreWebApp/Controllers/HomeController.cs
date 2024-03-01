using CoreWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        private List<ArticleModel> GetSampleDataFromDataSource()
        {
            // Simulate retrieving data from a database or other data source
            // Here, we're just creating some hardcoded sample data
            List<ArticleModel> articles = new List<ArticleModel>
            {
                new ArticleModel
                {
                    ArticleId = 1,
                    ArticleName = "Sample Article 1",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit.",
                    PublishedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                new ArticleModel
                {
                    ArticleId = 2,
                    ArticleName = "Sample Article 2",
                    Content = "Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                    PublishedDate = DateTime.UtcNow,
                    LastModifiedDate = DateTime.UtcNow
                },
                // Add more sample articles as needed
            };

            return articles;
        }
    


        private readonly ArticleContext articleContext1;

        public HomeController(ArticleContext articleContext)
        {
            articleContext1 = articleContext;
        }
        public IActionResult Index()
        {
            //List<ArticleModel> sampleDataList = GetSampleDataFromDataSource();
            List<ArticleModel> sampleDataList = articleContext1.Articles.ToList();

            // Check if data is retrieved successfully

            if (sampleDataList == null)
            {
                // Return an error response if data retrieval fails
                return StatusCode(500, "Failed to retrieve sample data.");
            }
            return View(sampleDataList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
