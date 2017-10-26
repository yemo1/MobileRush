using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Services;

namespace Mobilerush.Web.Common
{
    /// <summary>
    /// Summary description for Index1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class HeaderIndex : System.Web.Services.WebService
    {

        [WebMethod]
        public string MSISDN_HEADER()
        {
            
            string urlResponse = "", url = HttpContext.Current.Request.Url.Scheme + System.Uri.SchemeDelimiter + HttpContext.Current.Request.Url.Host +
                (HttpContext.Current.Request.Url.IsDefaultPort ? "" : ":" + HttpContext.Current.Request.Url.Port) + "/Default.mhtm";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();


                using (Stream stream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    String responseString = reader.ReadToEnd();
                    urlResponse = responseString;
                }
            }
            catch (Exception ex)
            {

                urlResponse = "XXX-XXXXXXXX";
                AppUtil.LogFileWrite(url + Environment.NewLine + ex.ToString());
            }
            return urlResponse;
        }
    }
}
