using Mobilerush.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobilerush.Domain.Entities;

namespace Mobilerush.Domain.Concrete
{
    public class ServiceHeaderRepository : IServiceHeader
    {
        private readonly EFDbContext context = new EFDbContext();

        public IEnumerable<ServiceHeader> ServiceHeaders
        {
            get
            {
                return context.ServiceHeaders;
            }
        }

        public ServiceHeader DeleteServiceHeader(int headerId)
        {
            ServiceHeader dbentry = context.ServiceHeaders.Find(headerId);
            if (dbentry != null)
            {
                context.ServiceHeaders.Remove(dbentry);
                context.SaveChanges();
            }
            return dbentry;
        }

        public ServiceHeader GetServiceHeader(string servicename)
        {
            return context.ServiceHeaders.FirstOrDefault(s => s.ProductName == servicename | s.ServiceName == servicename);
        }

        public ServiceHeader GetServiceHeader(int headerId)
        {
            return context.ServiceHeaders.FirstOrDefault(s => s.HeaderId==headerId);
        }

        public ServiceHeader GetServiceHeader(string servicename, string productname)
        {
            return context.ServiceHeaders.FirstOrDefault(s => s.ProductName == productname & s.ServiceName == servicename);
        }

        public ServiceHeader GetServiceHeader(string servicename, string productname, string productcode)
        {
            return context.ServiceHeaders.FirstOrDefault(s => s.ProductName == productname & s.ServiceName == servicename & s.ProductCode==productcode);
        }

        public void SaveServiceHeader(ServiceHeader serviceheader)
        {
            if (serviceheader.HeaderId == 0)
            {
                context.ServiceHeaders.Add(serviceheader);
            }
            else
            {
                ServiceHeader dbentry = context.ServiceHeaders.Find(serviceheader.HeaderId);
                if (dbentry != null)
                {
                    dbentry.Category = serviceheader.Category;
                    dbentry.CategoryLabel = serviceheader.CategoryLabel;
                    dbentry.Description = serviceheader.Description;
                    dbentry.HomeCategory = serviceheader.HomeCategory;
                    dbentry.HomeCategoryLabel = serviceheader.HomeCategoryLabel;
                    dbentry.ImageUrl = serviceheader.ImageUrl;
                    dbentry.IsActive = serviceheader.IsActive;
                    dbentry.MenuCategory = serviceheader.MenuCategory;
                    dbentry.MenuCategoryLabel = serviceheader.MenuCategoryLabel;
                    dbentry.ProductCode = serviceheader.ProductCode;
                    dbentry.ProductName = serviceheader.ProductName;
                    dbentry.ServiceName = serviceheader.ServiceName;
                    dbentry.ServiceLabel = serviceheader.ServiceLabel;
                    dbentry.ServiceUrl = serviceheader.ServiceUrl;
                    dbentry.ServiceParams = serviceheader.ServiceParams;
                    dbentry.ParamsType = serviceheader.ParamsType;
                    dbentry.TimeFormat = serviceheader.TimeFormat;
                }
            }
            context.SaveChanges();
        }

    }
}
