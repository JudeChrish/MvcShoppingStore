using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OnlineShoppingStore.WEBUI
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapRoute(
            //  name: "Custom1",
            //  url: "{CurrCategory}",
            //  defaults: new { controller = "Product", action = "AllProducts", CurrCategory = "MEN", Page = 1 }
            //  );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Product", action = "AllProducts", id = UrlParameter.Optional }
            );
        }
    }
}
