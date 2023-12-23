using BLL;
using BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace payroll_UI.Areas.User.Controllers
{
    public class MilliUnitController : Controller
    {
        private MillUnitBL millUnitBL;

        public MilliUnitController()
        {
            millUnitBL = new MillUnitBL();
        }

        [Authorize(Roles = "Admin")]

        // GET: User/MilliUnit
        public ActionResult Index()
        {
            var listUnitDepart = millUnitBL.GetAll();

            return View(listUnitDepart);
        }

        [HttpPost]
        public ActionResult Create(tbl_millUnit MillUnit)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    millUnitBL.Create(MillUnit);
                    return RedirectToAction("Index");

                }else
                {
                    return View();
                }

            }catch(Exception ex) 
            {
                TempData["ErrorMsg"] = "There something problem " + ex.Message;
                return RedirectToAction("Index");

            }
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            try
            {
                return RedirectToAction("Index");

            }
            catch(Exception ex)
            {
                TempData["ErrorMsg"] = "There something problem " + ex.Message;
                return RedirectToAction("Index");
            }
        }
    }
}