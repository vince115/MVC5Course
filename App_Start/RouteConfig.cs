﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC5Course
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            // 預設路由
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            //Staff路由
            routes.MapRoute(
                name: "StaffRoute",
                url: "Staff/{action}/{id}",
                defaults: new { controller = "Staff", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
