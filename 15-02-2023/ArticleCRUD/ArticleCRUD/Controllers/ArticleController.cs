using ArticleCRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using log4net;
using ArticleCRUD.filters;

namespace ArticleCRUD.Controllers
{
    
    public class ArticleController : Controller
    {

        // GET: Article
        /*public ActionResult Index()
        {
            var articles = ArticleDatabase.GetAllArticles();
            return View(articles);
        }*/
       
        public ActionResult Index(int? page, string sortOrder)
        {

            
            ViewBag.CurrentSort = sortOrder;
            ViewBag.TitleSortParam = string.IsNullOrEmpty(sortOrder) ? "title_desc" : "";
            ViewBag.DateSortParam = sortOrder == "PublishedDate" ? "publishedDate_desc" : "PublishedDate";

            var articles = ArticleDatabase.GetAllArticles();

            switch (sortOrder)
            {
                case "title_desc":
                    articles = articles.OrderByDescending(a => a.Title).ToList();
                    break;
                case "PublishedDate":
                    articles = articles.OrderBy(a => a.PublishedDate).ToList();
                    break;
                case "publishedDate_desc":
                    articles = articles.OrderByDescending(a => a.PublishedDate).ToList();
                    break;
                default:
                    articles = articles.OrderBy(a => a.Title).ToList();
                    break;
            }

            int pageSize = 10;
            int pageNumber = (page ?? 1);
           
            return View(articles.ToPagedList(pageNumber, pageSize));
        }





        [HandleError]
        // GET: Article/Details/5
        public ActionResult Details(int id)
        {
            var row = ArticleDatabase.GetArticleById(id);
            return View(row.First());
        }

        [HandleError]
        // GET: Article/Create
        public ActionResult Create()
        {
            return View();
        }

        [HandleError]
        
        // POST: Article/Create
        [HttpPost]
        public ActionResult Create(ArticleModel article)
        {
            try
            {

                
                int articleId=article.ArticleId;
                string articleName=article.Title;
                string content=article.Content;
                DateTime publishedDate=article.PublishedDate;
                DateTime lastModifiedDate=article.LastModifiedDate;
                bool b = ArticleDatabase.InsertArticle(articleName, content, publishedDate,lastModifiedDate);

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

        [HandleError]
        [OutputCache(Duration = 20)]
        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            var row = ArticleDatabase.GetArticleById(id);
            return View(row.First());
            
        }

        [HandleError]
        // POST: Article/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ArticleModel article)
        {
            try
            {
                int articleId = article.ArticleId;
                string articleName = article.Title;
                string content = article.Content;
                DateTime publishedDate = article.PublishedDate;
                DateTime lastModifiedDate = article.LastModifiedDate;

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

        [HandleError]
        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            var row = ArticleDatabase.GetArticleById(id);
            return View(row.First());
           
        }

        [HandleError]
        // POST: Article/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ArticleModel article)
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
