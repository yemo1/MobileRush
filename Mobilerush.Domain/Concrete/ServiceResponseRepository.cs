using Mobilerush.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilerush.Domain.Entities;

namespace Mobilerush.Domain.Concrete
{
    public class ServiceResponseRepository : IServiceResponse
    {
        private readonly EFDbContext context = new EFDbContext();

        public IEnumerable<ServiceResponse> ServiceResponses
        {
            get
            {
                return context.ServiceResponses;
            }
        }

        public ServiceResponse DeleteServiceResponse(int responseId)
        {
            ServiceResponse dbentry = context.ServiceResponses.Find(responseId);
            if (dbentry != null)
            {
                context.ServiceResponses.Remove(dbentry);
                context.SaveChanges();
            }
            return dbentry;
        }

        public ServiceResponse GetServiceResponse(int responseId)
        {
            return context.ServiceResponses.FirstOrDefault(r => r.ResponseId == responseId | r.RequestId==responseId);
        }

        public ServiceResponse GetServiceResponse(int responseId, int requestId)
        {
            return context.ServiceResponses.FirstOrDefault(r => r.RequestId == requestId & r.ResponseId==responseId);
        }


        public void SaveServiceResponse(ServiceResponse serviceresponse)
        {
            if (serviceresponse.ResponseId == 0)
            {
                context.ServiceResponses.Add(serviceresponse);
            }
            else
            {
                ServiceResponse dbentry = context.ServiceResponses.Find(serviceresponse.ResponseId);
                if (dbentry != null)
                {
                    dbentry.Description = serviceresponse.Description;
                    dbentry.RequestId = serviceresponse.RequestId;
                    dbentry.StatusCode = serviceresponse.StatusCode;
                    dbentry.Timestamped = serviceresponse.Timestamped;
                }
            }
            context.SaveChanges();
        }

    }
}
