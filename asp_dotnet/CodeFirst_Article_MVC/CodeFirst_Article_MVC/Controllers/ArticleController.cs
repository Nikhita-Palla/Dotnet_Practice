using CodeFirst_Article_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeFirst_Article_MVC.Controllers
{
    public class ArticleController : Controller
    {
        ArticleContext articlesContext = new ArticleContext();
        CategoryContext categoryContext = new CategoryContext();
        UserContext userContext = new UserContext();
        // GET: Article
        public ActionResult Index()
        {
            var articlesList=articlesContext.Articles.ToList();
            return View(articlesList);
        }

        // GET: Article/Details/5
        public ActionResult Details(int id)
        {
            var articleModel = articlesContext.Articles.Where(model=>model.ArticleId==id).FirstOrDefault();
            return View(articleModel);
        }

        // GET: Article/Create
        public ActionResult Create()
        {
            var users = GetAllUsers(); // Retrieve users
            ViewData["UserId"] = new SelectList(users, "UserId", "UserName");

            var categories = GetAllCategories(); // Retrieve categories
            ViewData["CategoryId"] = new SelectList(categories, "CategoryId", "CategoryName");

            return View();
            
        }
        public IEnumerable<UserModel> GetAllUsers()
        {
            var userItems = userContext.Authors.ToList();
            return userItems;
        }
        public IEnumerable<CategoryModel> GetAllCategories()
        {
            var categoryItems = categoryContext.Categories.ToList();
            return categoryItems;
        }

        // POST: Article/Create
        [HttpPost]
        public ActionResult Create(ArticleModel collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    articlesContext.Articles.Add(collection);
                    int a = articlesContext.SaveChanges();
                    if (a > 0)
                    {
                        ModelState.Clear();
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.InsertMessage("Something went wrong!");
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            var row = articlesContext.Articles.Where(model => model.ArticleId == id).FirstOrDefault();
            return View(row);
            
        }

        // POST: Article/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ArticleModel article)
        {
            try
            {
                articlesContext.Entry(article).State = EntityState.Modified;
                int a = articlesContext.SaveChanges();
                if (a > 0)
                {
                    ModelState.Clear();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.InsertMessage("Something went wrong");
                }


                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Article/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ArticleModel article)
        {
            try
            {
                var row = articlesContext.Articles.Where(model => model.ArticleId == id).FirstOrDefault();
                articlesContext.Articles.Remove(row);
                int a = articlesContext.SaveChanges();
                if (a > 0)
                {
                    ModelState.Clear();
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.InsertMessage("Something went wrong");
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
