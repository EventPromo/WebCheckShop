using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebCheckShop
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");            

            routes.MapRoute(
                "User",
                "user/{id}",
                new { controller = "Account", action = "Index" }
            );

            routes.MapRoute(
                "Check",
                "check/{id}",
                new { controller = "Check", action = "Index" }
            );

            routes.MapRoute(
                "Request",
                "request/{id}",
                new { controller = "Check", action = "Request" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}