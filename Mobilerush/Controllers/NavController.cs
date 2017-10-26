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
    public class NavController : Controller
    {
        private IServiceHeader repository;
        private MSISDN msisdntory= new MSISDN();

        public NavController(IServiceHeader repo)
        {
            repository = repo;
        }
        [Route("Nav")]
        [Route("Nav/Menu")]
        [Route("Menu")]
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            if (category == null) ViewBag.SelectedCategory = "Home";

            //FillMSISDN();
            List<MenuViewModel> menus= new List<MenuViewModel>();
            IEnumerable<string> categories = repository.ServiceHeaders.Select(x => x.Category).Distinct().OrderByDescending(x=>x);
            foreach(string cat in categories)
            {
                menus.Add(
                new MenuViewModel
                {
                    Title = repository.ServiceHeaders.FirstOrDefault(f => f.Category == cat).CategoryLabel,
                    Name = cat,
                    MenuItems = SubMenus(cat)
                    
                });

                
            }
            return PartialView(menus);
        }

        public PartialViewResult SubMenu(string subcategory = null)
        {
            ViewBag.SelectedCategory = subcategory;
            IEnumerable<string> subcategories = repository.ServiceHeaders.Select(x => x.MenuCategory).Distinct().OrderBy(x => x);
            return PartialView(subcategories);
        }

        public IEnumerable<SubMenuViewModel> SubMenus(string category = null)
        {
            IEnumerable<SubMenuViewModel> menus = repository.ServiceHeaders.Where(w=>w.Category==category).Select(s=> new { s.MenuCategory,s.MenuCategoryLabel}).Distinct().Select(x =>
             new SubMenuViewModel
             {
                 Title= x.MenuCategoryLabel,
                 Name = x.MenuCategory,
                 Map = x.MenuCategory
                 
             });
            return menus;
        }


    }
}