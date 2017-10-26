using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Web.Mvc;

namespace Mobilerush.Domain.Entities
{
    public class ServiceHeader
    {
        [HiddenInput(DisplayValue = false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HeaderId { get; set; }
        public string ServiceName { get; set; }

        public string ServiceLabel { get; set; }

        public string ProductName { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string MenuCategory { get; set; }

        public string MenuCategoryLabel { get; set; }

        public string Category { get; set; }

        public string CategoryLabel { get; set; }

        public string ProductCode { get; set; }

        public bool IsActive { get; set; }

        public string ServiceUrl { get; set; }

        public string ServiceParams { get; set; }

        public int ParamsType { get; set; }

        public string ImageUrl { get; set; }

        public string HomeCategory { get; set; }

        public string HomeCategoryLabel { get; set; }

        public string TimeFormat { get; set; }

        //HomeCategory:
        //Trending
        //Recommended
        //Featured
        //None



    }
}
