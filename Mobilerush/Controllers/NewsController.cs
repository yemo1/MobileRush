﻿using Mobilerush.Domain.Abstract;
using Mobilerush.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mobilerush.Web.Controllers
{
    public class NewsController : Controller
    {
        private readonly IServiceHeader repository;
        private List<PageSectionViewModel> model = new List<PageSectionViewModel>();

        public NewsController(IServiceHeader repo)
        {
            repository = repo;
            model = add();
        }

        [Route("News")]
        [Route("News/Index")]
        public ActionResult Index()
        {
            return View(model);
        }

        [Route("News/Load/{map?}")]
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
                .Where(w => w.Category == "News")
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