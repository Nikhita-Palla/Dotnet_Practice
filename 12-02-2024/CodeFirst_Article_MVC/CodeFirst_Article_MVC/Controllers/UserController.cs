using CodeFirst_Article_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace CodeFirst_Article_MVC.Controllers
{
    public class UserController : Controller
    {
        UserContext userContext=new UserContext();
        // GET: User
        public ActionResult UserIndex()
        {
            var userItems=userContext.Authors.ToList();
            return View(userItems);
        }

        public ActionResult Create(UserModel user) 
        {
            if(ModelState.IsValid)
            {
                userContext.Authors.Add(user);
                int a=userContext.SaveChanges();
                if(a>0)
                {
                    ModelState.Clear();
                    return RedirectToAction("UserIndex");
                }
                else
                {
                    ViewBag.InsertMessage("Something went wrong!");
                }
            }
            return View();
        }
        public ActionResult Edit(int id)
        {
            var row = userContext.Authors.Where(model => model.UserId == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(UserModel user)
        {
            
                userContext.Entry(user).State=EntityState.Modified;
                int a=userContext.SaveChanges();
                if(a>0)
                {
                    ModelState.Clear();
                    return RedirectToAction("UserIndex");
                }
                else
                {
                    ViewBag.InsertMessage("Something went wrong");
                }

            
            return View();
        }

        public ActionResult Delete(int id)
        {
            var row=userContext.Authors.Where(model=>model.UserId == id).FirstOrDefault();
            userContext.Authors.Remove(row);
            int a=userContext.SaveChanges();
            if (a > 0)
            {
                ModelState.Clear();
                return RedirectToAction("UserIndex");
            }
            else
            {
                ViewBag.InsertMessage("Something went wrong");
            }
            return View();
        }

        public ActionResult Details(int id)
        {
            var row=userContext.Authors.Where(model=> model.UserId == id).FirstOrDefault();
            return View(row);
        }
    }
}