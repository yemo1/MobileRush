using Mobilerush.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mobilerush.Web.Models
{
    public class HomeViewModel
    {
        public IEnumerable<ServiceHeader> Trending { get; set; }

        public IEnumerable<ServiceHeader> Featured { get; set; }

        public IEnumerable<ServiceHeader> Recommended { get; set; }

    }
}