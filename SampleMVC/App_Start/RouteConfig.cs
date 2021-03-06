﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SampleMVC
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.MapMvcAttributeRoutes();

            //routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            //http://localhost:8585/Home/Index
            //http://localhost:8585
            //http://localhost:8585/contact
            //http://localhost:8585/about.aspx
            //routes.MapRoute(
            //    name: "VI2",
            //    url: "VI2",
            //    defaults: new { controller = "ViewEx2", action = "Index" }
            //);

            routes.MapRoute(
                name: "abc",
                url: "contact",
                defaults: new { controller = "Home", action = "Contact" }
            );

            routes.MapRoute(
                name: "About",
                url: "about",
                defaults: new { controller = "Home", action = "About" }
            );

            routes.MapRoute(
                name: "MP",
                url: "ModelParamsTest/{id}/{name}",
                defaults: new { controller = "ViewEx", action = "ModelEx1", id=UrlParameter.Optional, name=UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id=UrlParameter.Optional }
            );
        }
    }
}
