using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Categories()
        {
            CategoryServices cs = new CategoryServices();
            ViewBag.categories = cs.GetMany().ToList();
            return View();
        }
        public ActionResult Inbox()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Profile()
        {
            return View();
        }
        public ActionResult Rewards()
        {
            return View();
        }
        public ActionResult Reports()
        {
            return View();
        }
        public ActionResult Ideas()
        {
            return View();
        }
        public ActionResult Users()
        {
            return View();
        }
        public ActionResult Achievements()
        {
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