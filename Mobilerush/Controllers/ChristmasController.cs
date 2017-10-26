using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ChristmasData;

namespace Mobilerush.Web.Controllers
{
   
    public class ChristmasController : Controller
    {
        // GET: Christmas
        [Route("Christmas")]
        public ActionResult Index()
        {
            ChristmasEntities db = new ChristmasEntities();
            var c = from d in db.Christmas
                    select d;
            return View(c.ToList());
        }
    }
}