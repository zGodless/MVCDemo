// Decompiled with JetBrains decompiler
// Type: MvcViewApp.Controllers.RazorTestController
// Assembly: MvcViewApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1B978DB-20D1-440A-9258-D8ED214AABDF
// Assembly location: D:\MVC\MvcViewApp\bin\MvcViewApp.dll

using System.Web.Mvc;

namespace MvcViewApp.Controllers
{
  public class RazorTestController : Controller
  {
    public ActionResult Index()
    {
      return (ActionResult) this.View();
    }

    public ActionResult PartialViewTest()
    {
      this.ViewData["Msg"] = (object) "this is a message";
      return (ActionResult) this.PartialView();
    }

    public ActionResult ActionTest()
    {
      return (ActionResult) this.View();
    }
  }
}
