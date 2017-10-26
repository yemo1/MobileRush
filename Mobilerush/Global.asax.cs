using Mobilerush.Domain.Entities;
using Mobilerush.Web.Binders;
using Mobilerush.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Mobilerush.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ModelBinders.Binders.Add(typeof(MSISDN), new MSISDNModelBinder());
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

    }
}
