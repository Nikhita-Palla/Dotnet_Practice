using ArticleCRUD.Models;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ArticleCRUD.Controllers
{
    public class AccountsController : Controller
    {
        [AllowAnonymous]
        // GET: Accounts/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Accounts/Register
        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(UserModel model)
        {
            if (ModelState.IsValid)
            {
                string name = model.Name;
                string pwd = model.password;
                bool b = UserAuthentication.register(name, pwd);
                if (b)
                {
                    return RedirectToAction("Login", "Accounts");
                }

              

            }

            return View(model);
        }

        // GET: Accounts/Login
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View();
        }

        // POST: Accounts/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public ActionResult Login(UserModel model)
        {
            if (ModelState.IsValid)
            {
                bool b = UserAuthentication.validate(model.Name, model.password);
                if (b)
                {
                    FormsAuthentication.SetAuthCookie(model.Name,false);
                    return RedirectToAction("Index", "Article");
                }
            }
            return View(model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Logout()
        {
            

            FormsAuthentication.SignOut();
           
            return RedirectToAction("Login", "Accounts");
            
        }
    }
}