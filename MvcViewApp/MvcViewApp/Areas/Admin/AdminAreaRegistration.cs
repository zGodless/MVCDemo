// Decompiled with JetBrains decompiler
// Type: MvcViewApp.Areas.Admin.AdminAreaRegistration
// Assembly: MvcViewApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1B978DB-20D1-440A-9258-D8ED214AABDF
// Assembly location: D:\MVC\MvcViewApp\bin\MvcViewApp.dll

using System.Web.Mvc;

namespace MvcViewApp.Areas.Admin
{
  public class AdminAreaRegistration : AreaRegistration
  {
    public override string AreaName
    {
      get
      {
        return "Admin";
      }
    }

    public override void RegisterArea(AreaRegistrationContext context)
    {
      context.MapRoute("Admin_default", "Admin/{controller}/{action}/{id}", (object) new
      {
        action = "Index",
        id = UrlParameter.Optional
      });
    }
  }
}
