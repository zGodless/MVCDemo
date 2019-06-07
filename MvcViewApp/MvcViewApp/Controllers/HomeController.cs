// Decompiled with JetBrains decompiler
// Type: MvcViewApp.Controllers.HomeController
// Assembly: MvcViewApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1B978DB-20D1-440A-9258-D8ED214AABDF
// Assembly location: D:\MVC\MvcViewApp\bin\MvcViewApp.dll

using Microsoft.CSharp.RuntimeBinder;
using MvcViewApp.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Web.Mvc;

namespace MvcViewApp.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      this.ViewData["One"] = (object) "天机老人";
      // ISSUE: reference to a compiler-generated field
      if (HomeController.\u003C\u003Eo__0.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        HomeController.\u003C\u003Eo__0.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Two", typeof (HomeController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      object obj = HomeController.\u003C\u003Eo__0.\u003C\u003Ep__0.Target((CallSite) HomeController.\u003C\u003Eo__0.\u003C\u003Ep__0, this.ViewBag, "bbbbbb");
      User user = new User() { Name = "ccccc" };
      this.TempData["Four"] = (object) "ddddd";
      return (ActionResult) this.View((object) user);
    }

    public ActionResult About()
    {
      // ISSUE: reference to a compiler-generated field
      if (HomeController.\u003C\u003Eo__1.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        HomeController.\u003C\u003Eo__1.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Message", typeof (HomeController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      object obj = HomeController.\u003C\u003Eo__1.\u003C\u003Ep__0.Target((CallSite) HomeController.\u003C\u003Eo__1.\u003C\u003Ep__0, this.ViewBag, "Your application description page.");
      return (ActionResult) this.View();
    }

    public ActionResult Contact()
    {
      // ISSUE: reference to a compiler-generated field
      if (HomeController.\u003C\u003Eo__2.\u003C\u003Ep__0 == null)
      {
        // ISSUE: reference to a compiler-generated field
        HomeController.\u003C\u003Eo__2.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, string, object>>.Create(Binder.SetMember(CSharpBinderFlags.None, "Message", typeof (HomeController), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[2]
        {
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, (string) null),
          CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.UseCompileTimeType | CSharpArgumentInfoFlags.Constant, (string) null)
        }));
      }
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      object obj = HomeController.\u003C\u003Eo__2.\u003C\u003Ep__0.Target((CallSite) HomeController.\u003C\u003Eo__2.\u003C\u003Ep__0, this.ViewBag, "Your contact page.");
      return (ActionResult) this.View();
    }
  }
}
