﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcViewApp.Controllers
{
    public class RazorTestController : Controller
    {
        // GET: RazorTest
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PartialViewTest()
        {
            ViewData["Msg"] = "this is a message";
            return PartialView();
        }

        public ActionResult ActionTest()
        {
            return View();
        }
    }
}