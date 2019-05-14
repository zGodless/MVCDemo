using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcControllerApp.Models;

namespace MvcControllerApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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

        public ActionResult UpdateCustomerInfo()
        {
            var model = new Customers {ContactName = "构造的一个"};
            ViewData["ContactName"] = "dfklsdjflsjd";
            return View(model);
        }

        [HttpPost]
        public RedirectResult UpdateCustomerInfo1(/*FormCollection form*//*string ContactName*/Customers customers)
        {
            //var contactName = ContactName;
            var model = customers;
            string controller = RouteData.Route.GetRouteData(this.HttpContext).Values["controller"].ToString();
            return new RedirectResult("Home/GetCustomerInfo?ContactName=" + model.ContactName);
            //return form["ContactName"];
        }

        [HttpGet]
        public string GetCustomerInfo()
        {
            return Request.QueryString["ContactName"];
        }
    }
}