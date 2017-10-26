using Mobilerush.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mobilerush.Web.Models
{
    public class PageSectionViewModel
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public IEnumerable<ServiceHeader> Items { get; set; }
    }
}