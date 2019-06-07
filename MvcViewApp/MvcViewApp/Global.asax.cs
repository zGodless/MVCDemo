// Decompiled with JetBrains decompiler
// Type: MvcViewApp.MvcApplication
// Assembly: MvcViewApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E1B978DB-20D1-440A-9258-D8ED214AABDF
// Assembly location: D:\MVC\MvcViewApp\bin\MvcViewApp.dll

using StackExchange.Profiling;
using StackExchange.Profiling.EntityFramework6;
using StackExchange.Profiling.Mvc;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace MvcViewApp
{
  public class MvcApplication : HttpApplication
  {
    protected void Application_Start()
    {
      AreaRegistration.RegisterAllAreas();
      FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
      RouteConfig.RegisterRoutes(RouteTable.Routes);
      BundleConfig.RegisterBundles(BundleTable.Bundles);
      MvcHandler.DisableMvcResponseHeader = true;
      MiniProfilerEF6.Initialize();
      MiniProfilerOptions options = new MiniProfilerOptions();
      options.RouteBasePath = "~/profiler";
      options.PopupRenderPosition = RenderPosition.Right;
      options.PopupMaxTracesToShow = 10;
      options.ResultsAuthorize = (Func<HttpRequest, bool>) (request => request.IsLocal);
      options.ResultsListAuthorize = (Func<HttpRequest, bool>) (request => true);
      options.StackMaxLength = 256;
      options.TrackConnectionOpenClose = true;
      MiniProfiler.Configure<MiniProfilerOptions>(options.ExcludeType<MiniProfilerOptions>("SessionFactory").ExcludeAssembly<MiniProfilerOptions>("NHibernate").ExcludeMethod<MiniProfilerOptions>("Flush").AddViewProfiling());
      MiniProfilerEF6.Initialize();
    }

    protected void Application_BeginRequest(object source, EventArgs e)
    {
      if (!this.Request.IsLocal)
        return;
      MiniProfiler.StartNew((string) null);
    }

    protected void Application_EndRequest()
    {
      MiniProfiler.Current?.Stop(false);
    }
  }
}
