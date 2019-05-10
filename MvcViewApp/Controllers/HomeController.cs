using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcViewApp.Models;

namespace MvcViewApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewData["One"] = "天机老人";
            ViewBag.Two = "bbbbbb";
            var _user = new User {Name = "ccccc"};
            TempData["Four"] = "ddddd";
            return View(_user);
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