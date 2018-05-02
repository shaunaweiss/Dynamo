using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Dynamo
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute("Generator", "Generator/{action}/{id}",
                new
                { controller = "Generator", action = "Index", id = "inputdata" });

           routes.MapRoute(
                        name: "Default",
                        url: "{controller}/{action}/{id}",
                        defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
                    );
        }
    }
}
