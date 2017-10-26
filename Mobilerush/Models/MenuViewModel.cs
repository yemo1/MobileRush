using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mobilerush.Web.Models
{
    public class MenuViewModel
    {
        public string Name { get; set; }

        public string Title { get; set; }

        //public string Url { get; set; }
        public  IEnumerable<SubMenuViewModel> MenuItems { get; set; }
    }
}