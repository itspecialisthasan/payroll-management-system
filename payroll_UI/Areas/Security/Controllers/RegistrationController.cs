using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace payroll_UI.Areas.Security.Controllers
{
    public class RegistrationController : Controller
    {
        private UserBL objRegistration;

        public RegistrationController()
        {
            objRegistration = new UserBL();
        }

        // GET: Security/Registration
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_user tbl_User) {
            try
            {
                if (ModelState.IsValid)
                {
                    objRegistration.Create(tbl_User);
                    TempData["SuccessMsg"] = "User Registered Successfully";
                    return RedirectToAction("Create");
                }
                else
                {
                    return View();
                }
            }
            catch(Exception ex) 
            {
                TempData["ErrorMsg"] = "User Registered Not..., Something Issues...!!" + ex.Message;
                return RedirectToAction("Create");
            }
        }
    }
}