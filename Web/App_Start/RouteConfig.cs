using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Categories",
                url: "{controller}/{action}"
            );
            routes.MapRoute(
               name: "Inbox",
               url: "{controller}/{action}"
            );
            routes.MapRoute(
               name: "Login",
               url: "{controller}/{action}"
            );
            routes.MapRoute(
               name: "Profile",
               url: "{controller}/{action}"
            );
            routes.MapRoute(
               name: "Users",
               url: "{controller}/{action}"
            );
            routes.MapRoute(
               name: "Reports",
               url: "{controller}/{action}"
            );
            routes.MapRoute(
               name: "Achievements",
               url: "{controller}/{action}"
            );
            routes.MapRoute(
               name: "Rewards",
               url: "{controller}/{action}"
            );
            routes.MapRoute(
              name: "Ideas",
              url: "{controller}/{action}"
           );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
