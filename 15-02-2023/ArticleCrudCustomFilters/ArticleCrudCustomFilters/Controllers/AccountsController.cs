using ArticleCrudCustomFilters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ArticleCrudCustomFilters.Controllers
{
    public class AccountsController : Controller
    {

        // GET: Accounts/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Accounts/Register
        [HttpPost]
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

        public ActionResult Login()
        {
            return View();
        }

        // POST: Accounts/Login
        [HttpPost]
        
        public ActionResult Login(UserModel model)
        {
            if (ModelState.IsValid)
            {
                bool b = UserAuthentication.validate(model.Name, model.password);
                if (b)
                {
                    FormsAuthentication.SetAuthCookie(model.Name, true);
                    return RedirectToAction("Index", "Article");
                }
            }
            return View(model);
        }


        [HttpPost]
       
        public ActionResult Logout()
        {


            FormsAuthentication.SignOut();

            return RedirectToAction("Login", "Accounts");

        }
    }
}