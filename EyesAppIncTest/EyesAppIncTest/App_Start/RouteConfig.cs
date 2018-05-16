using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace EyesAppIncTest
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{val1}/{val2}/{val3}/",
                defaults: new { action = "Index", val1 = UrlParameter.Optional, val2 = UrlParameter.Optional, val3 = UrlParameter.Optional }
            );
        }
    }
}

