using Mobilerush.Web.Common;
using System;
using System.Text;
using System.Web;

namespace Mobilerush.Web.HttpHandler
{
    public class WapHeader : IHttpHandler
    {
        /// <summary>
        /// You will need to configure this handler in the Web.config file of your 
        /// web and register it with IIS before being able to use it. For more information
        /// see the following link: http://go.microsoft.com/?linkid=8101007
        /// </summary>
        #region IHttpHandler Members

        public bool IsReusable
        {
            // Return false in case your Managed Handler cannot be reused for another request.
            // Usually this would be false in case you have some state information preserved per request.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            AppUtil.LogFileWrite(LogMessage());
            //write your handler implementation here.
            string returnValue = string.Empty;
            dynamic headerDash = null;
            dynamic headerUnder = null;
            dynamic HTTP_headerDash = null;
            dynamic HTTP_headerUnder = null;
            dynamic HEADER_headerDash = null;
            dynamic HEADER_headerUnder = null;

            headerDash = "X-MSISDN";
            headerUnder = "MSISDN";
            HTTP_headerDash = "HTTP_" + headerDash;
            HTTP_headerUnder = "HTTP_" + headerUnder;
            HEADER_headerDash = "HEADER_" + headerDash;
            HEADER_headerUnder = "HEADER_" + headerUnder;

            StringBuilder b = new StringBuilder();
            if (string.IsNullOrEmpty(HttpContext.Current.Request.ServerVariables[HTTP_headerDash]) == false)
                b.Append(HttpContext.Current.Request.ServerVariables[HTTP_headerDash] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.ServerVariables[HTTP_headerUnder]) == false)
                b.Append(HttpContext.Current.Request.ServerVariables[HTTP_headerUnder] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.ServerVariables[HEADER_headerDash]) == false)
                b.Append(HttpContext.Current.Request.ServerVariables[HEADER_headerDash] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.ServerVariables[HEADER_headerUnder]) == false)
                b.Append(HttpContext.Current.Request.ServerVariables[HEADER_headerUnder] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers[headerDash]) == false)
                b.Append(HttpContext.Current.Request.Headers[headerDash] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers[headerUnder]) == false)
                b.Append(HttpContext.Current.Request.Headers[headerUnder] + Environment.NewLine);

            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["HTTP-X-MSISDN"]) == false)
                b.Append(HttpContext.Current.Request.Headers["HTTP-X-MSISDN"] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["X-UP-CALLING-LINE-ID"]) == false)
                b.Append(HttpContext.Current.Request.Headers["X-UP-CALLING-LINE-ID"] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["HTTP_X_UP_CALLING_LINE_ID"]) == false)
                b.Append(HttpContext.Current.Request.Headers["HTTP_X_UP_CALLING_LINE_ID"] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["X_WAP_NETWORK_CLIENT_MSISDN"]) == false)
                b.Append(HttpContext.Current.Request.Headers["X_WAP_NETWORK_CLIENT_MSISDN"] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["X-Forwarded-For"]) == false && HttpContext.Current.Request.Headers["X-Forwarded-For"].Contains(".") == false)
                b.Append(HttpContext.Current.Request.Headers["X-Forwarded-For"] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["Proxy-Client-IP"]) == false && HttpContext.Current.Request.Headers["Proxy-Client-IP"].Contains(".") == false)
                b.Append(HttpContext.Current.Request.Headers["Proxy-Client-IP"] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["WL-Proxy-Client-IP"]) == false && HttpContext.Current.Request.Headers["WL-Proxy-Client-IP"].Contains(".") == false)
                b.Append(HttpContext.Current.Request.Headers["WL-Proxy-Client-IP"] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["HTTP_CLIENT_IP"]) == false && HttpContext.Current.Request.Headers["HTTP_CLIENT_IP"].Contains(".") == false)
                b.Append(HttpContext.Current.Request.Headers["HTTP_CLIENT_IP"] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["HTTP_X_FORWARDED_FOR"]) == false && HttpContext.Current.Request.Headers["HTTP_X_FORWARDED_FOR"].Contains(".") == false)
                b.Append(HttpContext.Current.Request.Headers["HTTP_X_FORWARDED_FOR"] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["x-real-ip"]) == false && HttpContext.Current.Request.Headers["x-real-ip"].Contains(".") == false)
                b.Append(HttpContext.Current.Request.Headers["x-real-ip"] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["HTTP_X_HTS_CLID"]) == false)
                b.Append(HttpContext.Current.Request.Headers["HTTP_X_HTS_CLID"] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["User-Identity-Forward-msisdn"]) == false)
                b.Append(HttpContext.Current.Request.Headers["User-Identity-Forward-msisdn"] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["HTTP_X_NOKIA_MSISDN"]) == false)
                b.Append(HttpContext.Current.Request.Headers["HTTP_X_NOKIA_MSISDN"] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["HTTP_X_UP_SUBNO"]) == false)
                b.Append(HttpContext.Current.Request.Headers["HTTP_X_UP_SUBNO"] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["HTTP_X_NETWORK_INFO"]) == false)
                b.Append(HttpContext.Current.Request.Headers["HTTP_X_NETWORK_INFO"] + Environment.NewLine);
            else if (string.IsNullOrEmpty(HttpContext.Current.Request.Headers["DEVICEID"]) == false)
                b.Append(HttpContext.Current.Request.Headers["DEVICEID"] + Environment.NewLine);

            else b.Append("XXX-XXXXXXXX");

            if (b != null)
                returnValue = b.ToString();
            else
                returnValue = "XXX-XXXXXXXX";
            //context.Response.ContentType = "text/html";
            context.Response.Write(returnValue);

        }

        string LogMessage()
        {
            string returnValue = string.Empty;

            returnValue += "Logging from " + AppUtil.GetIPAddress() + "................" + Environment.NewLine;


            dynamic headerDash = null;
            dynamic headerUnder = null;
            dynamic HTTP_headerDash = null;
            dynamic HTTP_headerUnder = null;
            dynamic HEADER_headerDash = null;
            dynamic HEADER_headerUnder = null;


            headerDash = "X-MSISDN";

            headerUnder = "MSISDN";

            HTTP_headerDash = "HTTP_" + headerDash;

            HTTP_headerUnder = "HTTP_" + headerUnder;

            HEADER_headerDash = "HEADER_" + headerDash;

            HEADER_headerUnder = "HEADER_" + headerUnder;


            returnValue += HTTP_headerDash + " = " + HttpContext.Current.Request.ServerVariables[HTTP_headerDash] + Environment.NewLine;

            returnValue += HTTP_headerUnder + " = " + HttpContext.Current.Request.ServerVariables[HTTP_headerUnder] + Environment.NewLine;

            returnValue += HEADER_headerDash + " = " + HttpContext.Current.Request.ServerVariables[HEADER_headerDash] + Environment.NewLine;

            returnValue += HEADER_headerUnder + " = " + HttpContext.Current.Request.ServerVariables[HEADER_headerUnder] + Environment.NewLine;

            returnValue += "Header(" + headerDash + ") = " + HttpContext.Current.Request.Headers[headerDash] + Environment.NewLine;


            returnValue += "Header(" + headerUnder + ") = " + HttpContext.Current.Request.Headers[headerUnder] + Environment.NewLine;


            return returnValue;
        }
        #endregion
    }
}
