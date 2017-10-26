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
    public class ServiceRequest
    {
        [HiddenInput(DisplayValue = false)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RequestId { get; set; }

        public string MSISDN { get; set; }

        public Guid TransactionId { get; set; }

        public string ClientIp { get; set; }

        public string SourceChannel { get; set; }

        public bool HeaderEnabled { get; set; }

        //[ForeignKey("ServiceHeader")]
        public int ServiceHeaderId { get; set; }

        public DateTime Timestamped { get; set; }
    }
}
