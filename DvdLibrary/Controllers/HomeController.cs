using DvdLibrary.Models;
using DvdLibrary.Models.Identity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DvdLibrary.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        [AllowAnonymous]
        public ActionResult Login()
        {
            LoginViewModel model = new LoginViewModel();

            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var userManager = HttpContext.GetOwinContext().GetUserManager<UserManager<AppUser>>();
            var authManager = HttpContext.GetOwinContext().Authentication;

           
            AppUser user = userManager.Find(model.UserName, model.Password);

            
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid username or password");

                return View(model);
            }
            else
            {
                
                var identity = userManager.CreateIdentity(user, DefaultAuthenticationTypes.ApplicationCookie);
                authManager.SignIn(new AuthenticationProperties { IsPersistent = model.RememberMe }, identity);

                if (!string.IsNullOrEmpty(returnUrl))
                    return Redirect(returnUrl);
                else
                    return RedirectToAction("List", "DVD");
            }
        }
    }
}
