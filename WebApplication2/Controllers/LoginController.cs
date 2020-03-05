using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class LoginController : Controller
    {
        tranningEntities obj = new tranningEntities();
        // GET: Login
        public ActionResult Login()
        {
            if (Session["User"] == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index","Emp");
            }
           
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
          
                //obj.LoginCheck(login.Username, login.Password);
                int? userId = obj.LoginCheck(login.Username, login.Password).FirstOrDefault();
                string message = string.Empty;
                switch (userId.Value)
                {
                    case -1:
                        message = "Username and/or password is incorrect.";
                        break;
                    default:
                    Session["User"] = login.Username;
                        return RedirectToAction("Index", "Emp");
                }
                return View();


        }
        public ActionResult Logout()
        {
            if (Session["User"] != null)
            {
                Session.Remove("User");
                return RedirectToAction("Login");
            }
            return RedirectToAction("Login");
        }
    }
}