// Decompiled with JetBrains decompiler
// Type: MvcViewApp.FilterConfig
// Assembly: MvcViewApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1B978DB-20D1-440A-9258-D8ED214AABDF
// Assembly location: D:\MVC\MvcViewApp\bin\MvcViewApp.dll

using System.Web.Mvc;

namespace MvcViewApp
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add((object) new HandleErrorAttribute());
    }
  }
}
