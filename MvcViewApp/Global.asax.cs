using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using StackExchange.Profiling;
using StackExchange.Profiling.EntityFramework6;
using StackExchange.Profiling.Mvc;


namespace MvcViewApp
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
           
             MiniProfilerEF6.Initialize();
             MiniProfiler.Configure(new MiniProfilerOptions
             {
                 RouteBasePath = "~/profiler",
                 PopupRenderPosition = RenderPosition.Right,  // defaults to left
                 PopupMaxTracesToShow = 10,
                 ResultsAuthorize = request => request.IsLocal,
                 ResultsListAuthorize = request =>
                 {
                     return true; // all requests are legit in this example
                 },
                 StackMaxLength = 256, 
                 TrackConnectionOpenClose = true
             }
                 .ExcludeType("SessionFactory")  // Ignore any class with the name of SessionFactory)
                 .ExcludeAssembly("NHibernate")  // Ignore any assembly named NHibernate
                     .ExcludeMethod("Flush") // Ignore any method with the name of Flush
                     .AddViewProfiling()
             );
              MiniProfilerEF6.Initialize();

        }
        protected void Application_BeginRequest(Object source, EventArgs e)
        {
            if (Request.IsLocal) // Example of conditional profiling, you could just call MiniProfiler.StartNew();
            {
                MiniProfiler.StartNew();
            }
        }

        protected void Application_EndRequest()
        {
            MiniProfiler.Current?.Stop(); // Be sure to stop the profiler!
        }
    }
}
