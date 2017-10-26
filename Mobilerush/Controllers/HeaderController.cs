using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mobilerush.Domain.Concrete;
using Mobilerush.Domain.Abstract;
using Mobilerush.Domain.Entities;
using Mobilerush.Web.Common;
using Mobilerush.Web.Models;
using Mobilerush.Web.Binders;

namespace Mobilerush.Web.Controllers
{
    public class HeaderController : Controller
    {

        private readonly IServiceRequest repository;
        private readonly IServiceHeader h_repository;
        public HeaderController(IServiceRequest repo, IServiceHeader h_repo)
        {
            repository = repo;
            h_repository = h_repo;
        }

        [Route("{category}/Header-{headerId}/Pay")]
        public ActionResult Pay(MSISDN msisdn, string category, string headerId)
        {
            //msisdn = (MSISDN)Session["XMSISDN"];

            if ((MSISDN)Session["XMSISDN"] != null)
            {
                msisdn = (MSISDN)Session["XMSISDN"];
            }
            else
            {
                msisdn = FillMSISDN();
            }

            try
            {
                //msisdn.Lines.FirstOrDefault().IsHeader)
                if (msisdn != null && msisdn.Lines.Count() > 0 && msisdn.Lines.FirstOrDefault().Phone != "XXX-XXXXXXXX")
                {
                    repository.Subscribe(Convert.ToInt32(headerId), msisdn.Lines.FirstOrDefault().IpAddress, msisdn.Lines.FirstOrDefault().Phone, msisdn.Lines.FirstOrDefault().IsHeader);
                }
                else
                {
                    return Redirect(Url.Action("Fill", new { category = category, headerId = headerId }));
                }
                //if (msisdn == null || msisdn.Lines.Count() < 1 || msisdn.Lines.FirstOrDefault().Phone == "XXX-XXXXXXXX")
                //{
                //    return Redirect(Url.Action("Fill", new { category = category, headerId = headerId }));

                //}
                //else
                //{
                //    repository.Subscribe(Convert.ToInt32(headerId), msisdn.Lines.FirstOrDefault().IpAddress, msisdn.Lines.FirstOrDefault().Phone, msisdn.Lines.FirstOrDefault().IsHeader);
                //}
            }
            catch (Exception ex)
            {
                AppUtil.LogFileWrite(ex.ToString());
            }
            if (string.IsNullOrEmpty(category)) category = "Home";
                
            return Redirect(Url.Action("Index", new { controller = category, action = "Index" }));
        }

        [Route("{category}/Header-{headerId}/Fill")]
        //[Route("Header/Fill/{category}{headerId}")]
        public ActionResult Fill(string msisdn, string category, string headerId)
        {
            var header = h_repository.GetServiceHeader(Convert.ToInt32(headerId));
            header.Category = category;
            var model = new HeaderViewModel();
            model.header = header;
            return View(model);
        }

        [Route("{category}/Header-{headerId}/Add")]
        [HttpPost]
        public ActionResult Add(string textPhone, string category, string headerId)
        {
            if (!string.IsNullOrEmpty(textPhone))
            {
                if (textPhone.StartsWith("0"))
                    textPhone = "234" + textPhone.TrimStart('0');
                var msisdn = new MSISDN();
                msisdn = (MSISDN)Session["XMSISDN"];
                //if (msisdn == null)
                //    msisdn = FillMSISDN();
                //13/02/2017

                if ((MSISDN)Session["XMSISDN"] != null)
                {
                    msisdn = (MSISDN)Session["XMSISDN"];
                }
                else
                {
                    msisdn = FillMSISDN();
                }
               
                var ipthis = msisdn.Lines.FirstOrDefault().IpAddress;
                msisdn.Clear();
                msisdn.AddItem(textPhone, ipthis, false);
                var newmsisdn = (MSISDN)Session["XMSISDN"];
                HttpContext.Session["XMSISDN"] = msisdn;

                try
                {
                    if (msisdn != null && msisdn.Lines.Count() > 0 && msisdn.Lines.FirstOrDefault().Phone != "XXX-XXXXXXXX")
                    
                        repository.Subscribe(Convert.ToInt32(headerId), msisdn.Lines.FirstOrDefault().IpAddress, msisdn.Lines.FirstOrDefault().Phone, msisdn.Lines.FirstOrDefault().IsHeader);
                        
                    //to return manual numbers here
                    else
                        return Redirect(Url.Action("Fill", new { category = category, headerId = headerId }));

                    var newmsisdn1 = (MSISDN)Session["XMSISDN"];

                }
                catch (Exception ex)
                {

                    AppUtil.LogFileWrite(ex.ToString());
                }
                if (string.IsNullOrEmpty(category)) category = "Home";
                return Redirect(Url.Action("Index", new { controller = category, action = "Index"}));
            }
            return Redirect(Request.Url.PathAndQuery);
        }

        MSISDN FillMSISDN()
        {
            //HTTPService.HeaderIndexSoapClient d = new HTTPService.HeaderIndexSoapClient();
            MSISDN msisdntory = new MSISDN();
            msisdntory.Clear();
            AppUtil app = new AppUtil();
            string msisdn = app.MSISDN_HEADER();
            if (msisdn == "XXX-XXXXXXXX")
            {
                msisdntory.AddItem(msisdn, AppUtil.GetIPAddress(), false);
            }
                
            else
            {
                msisdntory.AddItem(msisdn, AppUtil.GetIPAddress());
            }
                

            return msisdntory;
        }



    }
}