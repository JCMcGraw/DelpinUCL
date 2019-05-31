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
        public decimal deliveryPrice { get; private set; }
        public string modelName { get; private set; }



        public LeaseOrder(DateTime startDate, DateTime endDate, decimal leasePrice, int resourceID)
        {
            this.startDate = startDate;
            this.endDate = endDate;
            this.leasePrice = leasePrice;
            this.resourceID = resourceID;
        }

        public void SetDeliveryAddress(string deliveryStreet, int deliveryPostalCode, string deliveryCity, decimal deliveryPrice)
        {
            this.deliveryStreet = deliveryStreet;
            this.deliveryPostalCode = deliveryPostalCode;
            this.deliveryCity = deliveryCity;
            this.deliveryPrice = deliveryPrice;
        }

        public void SetLeaseOrderID(int leaseOrderID)
        {
            this.leaseOrderID = leaseOrderID;
        }

        public void SetDeliveryPrice(decimal deliveryPrice)
        {
            this.deliveryPrice = deliveryPrice;
        }

        public void SetModelName(string modelName)
        {
            this.modelName = modelName;
        }

        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0m;

            decimal numberOfDays = Convert.ToDecimal((endDate - startDate).TotalDays);
            totalPrice += (leasePrice * numberOfDays) + deliveryPrice;
            
            return totalPrice;
        }

        public int GetDaysRented()
        {
            int totalDaysRented = Convert.ToInt32((endDate - startDate).TotalDays);
            return totalDaysRented;
        }
    }
}
