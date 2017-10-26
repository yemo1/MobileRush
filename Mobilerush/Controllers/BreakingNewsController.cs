using Mobilerush.Domain.Abstract;
using Mobilerush.Domain.Entities;
using Mobilerush.Web.Common;
using Mobilerush.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Mobilerush.Web.Controllers
{
    public class BreakingNewsController : Controller
    {
        private readonly IServiceHeader repository;
        private readonly IServiceRequest h_repository;
        private List<PageSectionViewModel> model = new List<PageSectionViewModel>();

        public BreakingNewsController(IServiceHeader repo,IServiceRequest repos)
        {
            repository = repo;
            h_repository = repos;
            model = add();
        }
        // GET: BreakingNews
        [Route("BreakingNews")]
        [Route("BreakingNews/Index")]
        public ActionResult Index()
        {
            
            //Response.Write("<script language='javascript' type='text/javascript'>alert('Confirm subscription at &#8358;10/day.');</script>");
            //return View(model);
            //Response.Write("<script language='javascript' type='text/javascript'>alert('Confirm subscription at &#8358;10/day.');</script>");
            //MSISDN msisdn;
            //var service = repository.ServiceHeaders.Where(s => s.Category == "BreakingNews").SingleOrDefault();
            
            //if ((MSISDN)Session["XMSISDN"] != null)
            //{
            //    msisdn = (MSISDN)Session["XMSISDN"];
            //}
            //else
            //{
            //    msisdn = FillMSISDN();
            //}
            //if (msisdn == null || msisdn.Lines.Count() < 1 || msisdn.Lines.FirstOrDefault().Phone == "XXX-XXXXXXXX")
            //{
            //    TempData["msg"] = "<script>alert('Confirm subscription at &#8358;10/day.');</script>";
            //    //Response.Write("<script language='javascript' type='text/javascript'>alert('Confirm subscription at &#8358;10/day.');</script>");
            //    return Redirect(Url.Action("Fill", "Header", new { category = service.Category, headerId = service.HeaderId }));

            //}
            //else
            //{
            //    //Response.Write("<script language='javascript' type='text/javascript'>alert('Confirm subscription at &#8358;10/day.');</script>");
            //    h_repository.Subscribe(Convert.ToInt32(service.HeaderId), msisdn.Lines.FirstOrDefault().IpAddress, msisdn.Lines.FirstOrDefault().Phone, msisdn.Lines.FirstOrDefault().IsHeader);
            //}
            //if (string.IsNullOrEmpty(service.Category)) category = "Home";
            return View(model);
            //return Redirect(Url.Action("Index", new { controller = service.Category, action = "Index" }));
        }

        [Route("BreakingNews/Load/{map?}")]
        public RedirectResult Load(string map = null)
        {
            if (map == null)
                return Redirect(Url.Action("Index"));
            else
                return Redirect(Url.Action("Index") + "#" + map);
        }

        private List<PageSectionViewModel> add()
        {
            List<PageSectionViewModel> _model = new List<PageSectionViewModel>();
            var subcat =
                repository.ServiceHeaders
                .Where(w => w.Category == "BreakingNews")
                .Select(x => new { x.Category, x.CategoryLabel, x.MenuCategory, x.MenuCategoryLabel }).Distinct();
            foreach (var a in subcat)
            {
                _model.Add(
                new PageSectionViewModel
                {
                    Title = a.MenuCategoryLabel,
                    Name = a.CategoryLabel,
                    Items = repository.ServiceHeaders.Where(w => w.Category == a.Category & a.MenuCategory == w.MenuCategory)
                });
            }
            return _model;
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