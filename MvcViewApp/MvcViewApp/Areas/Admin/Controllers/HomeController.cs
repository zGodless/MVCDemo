// Decompiled with JetBrains decompiler
// Type: MvcViewApp.Areas.Admin.Controllers.HomeController
// Assembly: MvcViewApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1B978DB-20D1-440A-9258-D8ED214AABDF
// Assembly location: D:\MVC\MvcViewApp\bin\MvcViewApp.dll

using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Mvc;

namespace MvcViewApp.Areas.Admin.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return (ActionResult) this.View();
    }

    [OutputCache(Duration = 10, VaryByParam = "haha")]
    public ActionResult outputCache()
    {
      // ISSUE: reference to a compiler-generated field
      if (HomeController.\u003C\u003Eo__1.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        HomeController.\u003C\u003Eo__1.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Now", typeof (HomeController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      object obj = HomeController.\u003C\u003Eo__1.\u003C\u003Ep__0.Target((CallSite) HomeController.\u003C\u003Eo__1.\u003C\u003Ep__0, this.ViewBag, DateTime.Now.ToString());
      this.Response.Cache.SetOmitVaryStar(true);
      return (ActionResult) this.View();
    }
  }
}
