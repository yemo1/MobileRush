using Mobilerush.Domain.Abstract;
using Mobilerush.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mobilerush.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceHeader repository;

        public HomeController(IServiceHeader repo)
        {
            repository = repo;
        }
        [Route("~/")]
        [Route("Home")]
        [Route("Home/Index")]
        public ViewResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                Trending = repository.ServiceHeaders
                .Where(p => p.HomeCategory == "Trending"),
                Featured = repository.ServiceHeaders
                .Where(p => p.HomeCategory == "Featured"),
                Recommended = repository.ServiceHeaders
                .Where(p => p.HomeCategory == "Recommended")

            };

            return View(model);
        }

    }
}