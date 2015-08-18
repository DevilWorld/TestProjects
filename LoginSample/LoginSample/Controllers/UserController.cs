using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using LoginSample.Models;

namespace LoginSample.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {
                if (user.IsValid(user.UserID, user.Password))
                {
                    FormsAuthentication.SetAuthCookie(user.UserID, true);
                    return RedirectToAction("Index", "Home");
                }

                ModelState.AddModelError("Invalid Login", "Invalid Login Data");
            }

            return View(user);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}