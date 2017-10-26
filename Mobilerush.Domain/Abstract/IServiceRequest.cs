using Mobilerush.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilerush.Domain.Abstract
{
    public interface IServiceRequest
    {
        IEnumerable<ServiceRequest> ServiceRequests { get; }

        void SaveServiceRequest(ServiceRequest servicerequest);
        ServiceRequest DeleteServiceRequest(int requestId);

        ServiceRequest GetServiceRequest(int requestId);
        ServiceRequest GetServiceRequest(string transactionId);

        ServiceRequest GetServiceRequest(int requestId, string msisdn);

        ServiceRequest GetServiceRequest(int requestId, string msisdn, string transactionId);

        void Subscribe(int headerId,string ipAddress, string msisdn, bool IsHeaderEnabled = true, string sourceChannel = "Standard");
    }
}
