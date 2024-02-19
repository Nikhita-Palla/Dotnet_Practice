using Article_CustomAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Article_CustomAuth.Controllers
{
    public class AccountsController : Controller
    {

        // GET: Accounts/Register
        [AllowAnonymous]
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
                    TempData["RegisterMessage"] = "Registration Successful";
                    return RedirectToAction("Login", "Accounts");
                }
                TempData["RegisterMessage"] = "Registration failed";



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
        [AllowAnonymous]
        public ActionResult Login(UserModel model)
        {
            if (ModelState.IsValid)
            {
                // Validate user credentials
                bool isValid = UserAuthentication.validate(model.Name, model.password);
                
                if(isValid)
                {
                    
                    FormsAuthentication.SetAuthCookie(model.Name, true);
                    TempData["LoginMessage"] = "Login Successful";
                    return RedirectToAction("Index", "Article");
                }
                else
                {
                    TempData["LoginMessage"] = "Login failed";
                    
                    return RedirectToAction("Register", "Accounts");
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