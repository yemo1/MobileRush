using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Mobilerush.Web.HtmlHelpers
{

    public static class RouteCollectionExtensions
    {
        /// <summary>
        /// Maps the specified URL route and sets route value names to remove and default route values.
        /// </summary>
        /// <param name="routes">A collection of routes for the application.</param>
        /// <param name="name">The name of the route to map.</param>
        /// <param name="url">The URL pattern for the route.</param>
        /// <param name="routeValueNames">Comma separated string with route value names that should be removed when route generates URLs.</param>
        /// <param name="defaults">An object that contains default route values.</param>
        /// <returns>A reference to the mapped <see cref="RouteWithExclusions"/> object instance.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "2#")]
        public static Route MapRoute(this RouteCollection routes, string name, string url, string routeValueNames, object defaults)
        {
            if (routes == null)
            {
                throw new ArgumentNullException("routes");
            }
            if (url == null)
            {
                throw new ArgumentNullException("url");
            }

            Route item = new RouteWithExclusions(url, new MvcRouteHandler(), routeValueNames)
            {
                Defaults = new RouteValueDictionary(defaults),
                DataTokens = new RouteValueDictionary()
            };
            routes.Add(name, item);
            return item;
        }

        /// <summary>
        /// Maps the specified URL route and sets route value names to remove, default route values and constraints.
        /// </summary>
        /// <param name="routes">A collection of routes for the application.</param>
        /// <param name="name">The name of the route to map.</param>
        /// <param name="url">The URL pattern for the route.</param>
        /// <param name="routeValueNames">Comma separated string with route value names that should be removed when route generates URLs.</param>
        /// <param name="defaults">An object that contains default route values.</param>
        /// <param name="constraints">A set of expressions that specify values for the url parameter.</param>
        /// <returns>A reference to the mapped <see cref="RouteWithExclusions"/> object instance.</returns>
        [SuppressMessage("Microsoft.Design", "CA1054:UriParametersShouldNotBeStrings", MessageId = "2#")]
        public static Route MapRoute(this RouteCollection routes, string name, string url, string routeValueNames, object defaults, object constraints)
        {
            if (routes == null)
            {
                throw new ArgumentNullException("routes");
            }
            if (url == null)
            {
                throw new ArgumentNullException("url");
            }

            Route item = new RouteWithExclusions(url, new MvcRouteHandler(), routeValueNames)
            {
                Defaults = new RouteValueDictionary(defaults),
                Constraints = new RouteValueDictionary(constraints),
                DataTokens = new RouteValueDictionary()
            };
            routes.Add(name, item);
            return item;
        }
    }

}