using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Mobilerush.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.migrate.js",
                        "~/Scripts/jquery.fitvids.js",
                        "~/Scripts/jquery.isotope.js",
                        "~/Scripts/jquery.appear.js",
                        "~/Scripts/jquery.textillate.js",
                        "~/Scripts/jquery.lettering.js",
                        "~/Scripts/jquery.easypiechart.js",
                        "~/Scripts/jquery.nicescroll.js",
                        "~/Scripts/jquery.parallax.js",
                        "~/Scripts/jquery.slicknav.js"));

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                        "~/Scripts/nivo-lightbox.js",
                        "~/Scripts/count-to.js",
                        "~/Scripts/script.js",
                        "~/Scripts/owl.carousel.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizrr.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));
                     

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                       "~/Content/font-awesome.css",
                       "~/Content/slicknav.css",
                       "~/Content/style.css",
                       "~/Content/responsive.css",
                       "~/Content/colors/orange.css",
                       "~/Content/animate.css"));
        }
    }
}