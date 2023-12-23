using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace payroll_UI.Areas.Security.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        
        private payroll_dbEntities payroll_DbEntities;

        public LoginController()
        {
            payroll_DbEntities = new payroll_dbEntities(); 
        }

        // GET: Security/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(tbl_user tbl_User)
        {
            var isUserExist = payroll_DbEntities.tbl_user.Where(x => x.username == tbl_User.username && x.pasword == tbl_User.pasword).Count();

            if (isUserExist != 0)
            {
                FormsAuthentication.SetAuthCookie(tbl_User.username ,false);
                return RedirectToAction("Index", "Home", new { area = "Common" });
            }
            else
            {
                TempData["ErrorMsg"] = "Invalid Username or Password, Try Again...!!!";
                return View();
            }
        }


        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Login", new { area = "Security" });
        }
    }
}