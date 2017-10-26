using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilerush.Domain.Entities
{
    public class ServiceResponse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ResponseId { get; set; }

        public int RequestId { get; set; }

        public string StatusCode { get; set; }

        public string Description { get; set; }

        public DateTime Timestamped { get; set; }
    }
}
