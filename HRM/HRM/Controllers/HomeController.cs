using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRM.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            
          
            var nmbrofDept = db.Depts.Count();
            var nmbrofDivision = db.Divisions.Count();
            var nmbrofSection = db.Sections.Count();
            var nmbrofDesignation = db.Designation.Count();
            var nmbrofEmployee = db.Employee.Count();



            ViewBag.nmbrofDept = db.Depts.Count();
            ViewBag.nmbrofDivision = db.Divisions.Count();
            ViewBag.nmbrofSection = db.Sections.Count();
            ViewBag.nmbrofDesignation = db.Designation.Count();
            ViewBag.nmbrofEmployee = db.Employee.Count();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}