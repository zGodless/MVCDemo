﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCApp.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            ViewBag.Message = "First ASP.NET MVC application.";
            ViewBag.hahaha = "dfdf";
            return View();
        }

        public ActionResult ShowArticle()
        {
            return View("Article");
        }

        public string Say()
        {
            return "Hello, World!";
        }
    }
}