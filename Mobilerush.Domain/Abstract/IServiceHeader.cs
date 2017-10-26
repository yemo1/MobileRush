using Mobilerush.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilerush.Domain.Abstract
{
    public interface IServiceHeader
    {
        IEnumerable<ServiceHeader> ServiceHeaders { get; }

        void SaveServiceHeader(ServiceHeader serviceheader);
        ServiceHeader DeleteServiceHeader(int headerId);

        ServiceHeader GetServiceHeader(int headerId);
        ServiceHeader GetServiceHeader(string servicename);

        ServiceHeader GetServiceHeader(string servicename, string productname);

        ServiceHeader GetServiceHeader(string servicename, string productname, string productcode);
    }
}
