﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace sparsuli
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
              name: "Default",
              url: "{language}/{controller}/{action}/{id}",
              defaults: new { language = "ka", controller = "Home", action = "Index", id = UrlParameter.Optional }
          );
        }
    }
}
