using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Mobilerush.Domain.Entities;

namespace Mobilerush.Domain.Concrete
{
    public class EFDbContext: DbContext
    {
        public DbSet<ServiceHeader> ServiceHeaders { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }

        public  DbSet<ServiceResponse> ServiceResponses { get; set; }

    }
}
