using Mobilerush.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mobilerush.Web.Models
{
    public class HeaderViewModel
    {
        public string MSIDN { get; set; }
        public ServiceHeader header { get; set; }
    }
}