using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class LeaseOrder
    {
        public int leaseOrderID { get; private set; }
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }
        public decimal leasePrice { get; private set; }
        public int resourceID { get; private set; }
        public string modelName { get; private set; }

        public LeaseOrder(int leaseOrderID, DateTime startDate, DateTime endDate, decimal leasePrice, int resourceID, string modelName)
        {
            this.leaseOrderID = leaseOrderID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.leasePrice = leasePrice;
            this.resourceID = resourceID;
            this.modelName = modelName;
        }
    }
}
