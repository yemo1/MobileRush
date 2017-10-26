using Mobilerush.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobilerush.Domain.Entities
{
    public class MSISDN : IMSISDN
    {
        private List<MSISDNLine> lineCollection = new List<MSISDNLine>();

        public void AddItem(string msisdn, string ipaddress, bool isheader = true)
        {
            this.Clear();
            lineCollection.Add(new MSISDNLine { Phone = msisdn, IpAddress=ipaddress, IsHeader = isheader });
        }

        public void RemoveLine(string msisdn)
        {
            lineCollection.RemoveAll(p => p.Phone==msisdn);
            lineCollection.Clear();
        }


        public IEnumerable<MSISDNLine> Lines
        {
            get { return lineCollection; }
        }

        public void Clear()
        {
            lineCollection.Clear();
        }
    }

    public class MSISDNLine
    {
        public string Phone { get; set; }

        public string IpAddress { get; set; }

        public bool IsHeader { get; set; }

    }
}
