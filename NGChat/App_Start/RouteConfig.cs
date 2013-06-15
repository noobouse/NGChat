﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NGChat
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes, ref RouteBase signalRHubRoute)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            signalRHubRoute = routes.MapHubs();

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}