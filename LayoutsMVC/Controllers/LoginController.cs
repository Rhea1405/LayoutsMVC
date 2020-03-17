using LayoutsMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayoutsMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginPage()
        {
            return View();
        }
       public ActionResult validatelogin(LoginValidation lv)
        {
            if (ModelState.IsValid)
            {
                string username = Request.Form["username"];
                string password = Request.Form["password"];
                bool res = LayoutOperations.Checklogin(username, password);
                if (res == true)
                {
                    return View("validatelogin");
                }
                else
                {
                    return View("LoginPage");
                }
            }
            else
            {
                return View("LoginPage");
            }

            
            
        }
        
    }
}