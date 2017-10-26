using Mobilerush.Domain.Abstract;
using Mobilerush.Domain.Entities;
using Mobilerush.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mobilerush.Web.Controllers
{
    public class IVRController : Controller
    {
        private readonly IServiceHeader repository;
        private List<PageSectionViewModel> model = new List<PageSectionViewModel>();

        public IVRController(IServiceHeader repo)
        {
            repository = repo;
            model = add();
        }

        [Route("IVR")]
        [Route("IVR/Index")]
        public ActionResult Index()
        {
            var msisdn = (MSISDN)Session["XMSISDN"];
            if (msisdn != null && msisdn.Lines.FirstOrDefault().Phone != "XXX-XXXXXXXX") 
            {
                Response.Write("<script language='javascript' type='text/javascript'>alert('Subscription successful, dial 424 to meet with people.');</script>");
            }
            return View(model);
        }

        [Route("IVR/Load/{map?}")]
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
                .Where(w => w.Category == "IVR")
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
    }
}