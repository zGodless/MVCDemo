using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcViewApp.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 10, VaryByParam = "haha")]
        public ActionResult outputCache()
        {
            ViewBag.Now = DateTime.Now.ToString();
            Response.Cache.SetOmitVaryStar(true);
            return View();
        }
    }
}