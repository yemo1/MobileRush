using Mobilerush.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilerush.Domain.Abstract
{
    public interface IServiceResponse
    {
        IEnumerable<ServiceResponse> ServiceResponses { get; }

        void SaveServiceResponse(ServiceResponse serviceresponse);
        ServiceResponse DeleteServiceResponse(int responseId);

        ServiceResponse GetServiceResponse(int responseId);

        ServiceResponse GetServiceResponse(int responseId, int requestId);
    }
}
