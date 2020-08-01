using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVC_ASP_DOT_NET
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            // custom route
            routes.MapRoute(
                "MoviesByReleasedate",// name
                "movies/released/{year}/{month}",//url
                new { controller = "Movies", action = "ByReleaseDate" }, //defaults
                new { year = @"\d{4}", month = @"\d{2}" } // setting contraints year to be 4 digits & monthg to to be 2 digits
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
