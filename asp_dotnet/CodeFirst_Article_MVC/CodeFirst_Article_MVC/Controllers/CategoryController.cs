using CodeFirst_Article_MVC.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace CodeFirst_Article_MVC.Controllers
{
    public class CategoryController : Controller
    {
        CategoryContext categoryContext = new CategoryContext();        
        // GET: Category
        public ActionResult CategoryIndex()
        {
            var categories=categoryContext.Categories;
            return View(categories);
        }
        public ActionResult Create(CategoryModel category)
        {
            if(ModelState.IsValid==true)
            {
                categoryContext.Categories.Add(category);
                int a = categoryContext.SaveChanges();
                if (a > 0)
                {
                    ViewBag.AlertMessage = "Insertion Successful";
                    ModelState.Clear();
                    return RedirectToAction("CategoryIndex", "Create");
                   
                }
                else
                {
                    ViewBag.AlertMessage = "Something went wrong";
                   
                }
            }
            
            return View();
        }
        public ActionResult Edit(int id)
        {
            var row=categoryContext.Categories.Where(model=>model.CategoryId==id).FirstOrDefault();
            return View(row);
        }
        [HttpPost]
        public ActionResult Edit(CategoryModel categoryModel)
        {
            categoryContext.Entry(categoryModel).State = EntityState.Modified;
            int a= categoryContext.SaveChanges();
            if (a > 0)
            {
               
                ModelState.Clear();
                return RedirectToAction("CategoryIndex");

            }
            else
            {
                ViewBag.UpdateMessage = "Something went wrong!";
            }
            return View();
        }

        public ActionResult Delete(int id)
        {
            var row = categoryContext.Categories.Where(model => model.CategoryId == id).FirstOrDefault();
            categoryContext.Categories.Remove(row);
            categoryContext.SaveChanges();
            return RedirectToAction("CategoryIndex");
           
        }

        public ActionResult Details(int id)
        {
            var row= categoryContext.Categories.Where(model => model.CategoryId == id).FirstOrDefault();
            return View(row);
        }



        }
}