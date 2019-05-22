using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    public class LeaseOrder
    {
        public int leaseOrderID { get; private set; }
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }
        public decimal leasePrice { get; private set; }
        public int resourceID { get; private set; }
        public string deliveryStreet { get; private set; }
        public int deliveryPostalCode { get; private set; }
        public string deliveryCity { get; private set; }


        public LeaseOrder(DateTime startDate, DateTime endDate, decimal leasePrice, int resourceID)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.leasePrice = leasePrice;
            this.resourceID = resourceID;
        }

        public void AddDeliveryAddress(string deliveryStreet, int deliveryPostalCode, string deliveryCity)
        {
            this.deliveryStreet = deliveryStreet;
            this.deliveryPostalCode = deliveryPostalCode;
            this.deliveryCity = deliveryCity;
        }
    }
}
