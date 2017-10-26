using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Mobilerush.Web.HtmlHelpers;

namespace Mobilerush.Web
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            ////controller/category#subcategory

            ////routes.MapRoute(
            ////    name: "Default",
            ////    url: "{controller}/{action}/{id}",
            ////    defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            ////);
            ////routes.MapRoute(
            ////    "Header",
            ////    "Header/{action}/{headerId}",
            ////    new
            ////    {
            ////        controller = "Header",
            ////        action = "Pay",
            ////        headerId = UrlParameter.Optional
            ////    }
            ////);

            //routes.MapRoute(
            //    "Header",
            //    "{category}/Header-{headerId}/Pay",
            //    new { controller = "Header", action = "Pay" },
            //    new { category = string.Empty, headerId = @"\d+" }
            //);

            //routes.MapRoute(null, "",
            //    new
            //    {
            //        controller = "Home",
            //        action = "Index"
            //    });

            //routes.MapRoute(null, "{controller}",
            //    new
            //    {
            //        controller = "Home",
            //        action = "Index",
            //    });




            ////routes.MapRoute(null, "{controller}/{map}",
            ////    new
            ////    {
            ////        controller = "Home",
            ////        action = "Index",
            ////        map = UrlParameter.Optional
            ////    });

            //routes.MapRoute(
            //    "Default",
            //    "{controller}/{action}/{map}",
            //    //"headerId", // exclude these route values (comma separated list)
            //    new { controller = "Home", action = "Index", map = UrlParameter.Optional }
            //);


            //routes.MapRoute(null, "{controller}/{action}");
            ////http://localhost:2454/News?category=News&map=Lifestyle
            ////routes.MapRoute(
            ////    name: null,
            ////    url: "{controller}/{category}#{map}",
            ////    defaults: new { controller = "Home", action = "Index", category = UrlParameter.Optional, map = UrlParameter.Optional }
            ////);
        }
    }
}
