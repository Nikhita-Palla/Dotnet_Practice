using Article_CustomAuth.fillter;
using Article_CustomAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Article_CustomAuth.Controllers
{
    public class ArticleController : Controller
    {
        
        [Authorize(Roles = "Admin, Editor, Reader")]
        // GET: Article
        public ActionResult Index()
        {
            var articles = ArticleDatabase.GetAllArticles();
            return View(articles);
           
        }

        // GET: Article/Details/5
        
        [Authorize(Roles = "Admin, Editor, Reader")]
        public ActionResult Details(int id)
        {
            var row = ArticleDatabase.GetArticleById(id);
            return View(row.First());
            
        }

        // GET: Article/Create
        [Authorize(Roles = "Admin, Editor")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        [Authorize(Roles = "Admin, Editor")]
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                ArticleModel article = new ArticleModel();
                int articleId = Convert.ToInt32(collection["ArticleId"]);
                string articleName = collection["Title"];
                string content = collection["Content"];
                DateTime publishedDate = Convert.ToDateTime(collection["PublishedDate"]);
                DateTime lastModifiedDate = Convert.ToDateTime(collection["LastModifiedDate"]);
                bool b = ArticleDatabase.InsertArticle(articleName, content, publishedDate, lastModifiedDate);

                if (b)
                {
                    return RedirectToAction("Index");
                }
                return View();


            }
            catch
            {
                return View();
            }
        }
        [Authorize(Roles = "Admin")]
        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            var row = ArticleDatabase.GetArticleById(id);
            return View(row.First());
        }

        // POST: Article/Edit/5
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                ArticleModel article = new ArticleModel();
                int articleId = Convert.ToInt32(collection["ArticleId"]);
                string articleName = collection["Title"];
                string content = collection["Content"];
                DateTime publishedDate = Convert.ToDateTime(collection["PublishedDate"]);
                DateTime lastModifiedDate = Convert.ToDateTime(collection["LastModifiedDate"]);

                bool b = ArticleDatabase.UpdateArticle(articleId, articleName, content, publishedDate, lastModifiedDate);

                if (b)
                {
                    return RedirectToAction("Index");
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [Authorize(Roles = "Admin")]
        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            var row = ArticleDatabase.GetArticleById(id);
            return View(row.First());
        }
        [Authorize(Roles = "Admin")]
        // POST: Article/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {

            try
            {
                bool b = ArticleDatabase.DeleteArticle(id);
                if (b)
                {
                    return RedirectToAction("Index");
                }
                return View();

            }
            catch
            {
                return View();
            }
        }
    }
}
