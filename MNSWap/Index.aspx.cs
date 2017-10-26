using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;


namespace MNSSubscribe
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //?pID={}&phone={}&ds={}&tID={}
                string pID = (Request.QueryString["pID"] != null) ? Request.QueryString["pID"].ToString() : "",
                    phone = (Request.QueryString["phone"] != "") ? Request.QueryString["phone"].ToString() : "",
                    descr = (Request.QueryString["ds"] != null) ? Request.QueryString["ds"].ToString() : "",
                     tID = (Request.QueryString["tID"] != null) ? Request.QueryString["tID"].ToString() : "";
                if (string.IsNullOrEmpty(pID) != true && string.IsNullOrEmpty(phone) != true && string.IsNullOrEmpty(tID) != true)
                {
                    ClickMNS.ProductSubscribeReq wRequest = new ClickMNS.ProductSubscribeReq();
                    wRequest.channelID = 1; //check comment map
                    wRequest.MSISDN = phone;
                    wRequest.operDesc = descr;
                    wRequest.operTime = DateTime.Now.ToString("yyyyMMddHHmmss");
                    wRequest.transactionID = tID;
                    ClickMNS.MNSProductReqService ap = new ClickMNS.MNSProductReqService();
                    ClickMNS.SubscribeMNSProductRsp wResponse = ap.subscribeMNSProduct(wRequest);

                    Response.Write(wResponse.result.resultCode); //check comment map
                }
                else
                {
                    Response.Write("-1");
                }

            }
            catch (Exception ex)
            {

                Response.Write(ex.ToString());
            }
        }
    }
}

#region Comment Map

#region ChannelSource
//1  WEB
//2  WAP
//3  SMS
//4  CRM
//5  SYNC
//6  WEB IMPORT
//14 IVR
//15 PDA
//17 USSD
//9 Other 
#endregion

#region Result Code
//Status code Desc
//00000000	Success 
//10000002	operTime wrong format
//10000003	Invalid value or wrong format
//10000004	Unknown error

#endregion
#endregion