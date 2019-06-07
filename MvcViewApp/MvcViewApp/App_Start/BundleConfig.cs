// Decompiled with JetBrains decompiler
// Type: MvcViewApp.BundleConfig
// Assembly: MvcViewApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1B978DB-20D1-440A-9258-D8ED214AABDF
// Assembly location: D:\MVC\MvcViewApp\bin\MvcViewApp.dll

using System.Web.Optimization;

namespace MvcViewApp
{
  public class BundleConfig
  {
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
      bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));
      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));
      bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));
      bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrap.css", "~/Content/site.css"));
    }
  }
}
