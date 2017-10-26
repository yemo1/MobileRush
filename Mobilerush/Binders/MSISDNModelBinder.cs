using Mobilerush.Domain.Entities;
using Mobilerush.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mobilerush.Web.Binders
{

    public class MSISDNModelBinder : IModelBinder
    {
        private const string sessionKey = "XMSISDN";
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            MSISDN xmsisdn = null;
            if (controllerContext.HttpContext.Session != null)
            {
                xmsisdn = (MSISDN)controllerContext.HttpContext.Session[sessionKey];
            }
            if (xmsisdn == null || (xmsisdn.Lines.Count() > 0 && xmsisdn.Lines.FirstOrDefault().IsHeader == false))
            {
                xmsisdn = FillMSISDN();
                if (controllerContext.HttpContext.Session != null)
                {
                    controllerContext.HttpContext.Session[sessionKey] = xmsisdn;
                }

            }

            return xmsisdn;
        }

        MSISDN FillMSISDN()
        {
            //HTTPService.HeaderIndexSoapClient d = new HTTPService.HeaderIndexSoapClient();
            MSISDN msisdntory = new MSISDN();
            msisdntory.Clear();
            AppUtil app = new AppUtil();
            string msisdn = app.MSISDN_HEADER();
            if (msisdn == "XXX-XXXXXXXX")
                msisdntory.AddItem(msisdn, AppUtil.GetIPAddress(), false);
            else
                msisdntory.AddItem(msisdn, AppUtil.GetIPAddress());

            return msisdntory;
        }
    }

}