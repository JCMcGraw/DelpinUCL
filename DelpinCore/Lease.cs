using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class Lease
    {
        public int leaseID { get; private set; }
        public int debtorID { get; private set; }
        public int branchID { get; private set; }
        public DateTime dateCreated { get; private set; }
        private List<LeaseOrder> leaseOrders = new List<LeaseOrder>();

        public Lease(int debtorID, int branchID)
        {
            this.debtorID = debtorID;
            this.branchID = branchID;
            this.dateCreated = DateTime.Now;
        }

        public Lease(int debtorID, int branchID, int leaseID, DateTime dateCreated)
        {
            this.leaseID = leaseID;
            this.debtorID = debtorID;
            this.branchID = branchID;
            this.dateCreated = dateCreated;
        }

        public void AddLeaseOrder(LeaseOrder leaseOrder)
        {
            leaseOrders.Add(leaseOrder);
        }

        public void AddLeaseOrderAtSpecificIndes(LeaseOrder leaseOrder, int indexToAddAt)
        {
            leaseOrders.Insert(indexToAddAt, leaseOrder);
        }

        public void RemoveLeaseOrder(int indexToRemove)
        {
            leaseOrders.RemoveAt(indexToRemove);
        }

        public void SetLeaseID(int leaseID)
        {
            this.leaseID = leaseID;
        }

        public List<LeaseOrder> GetLeaseOrders()
        {
            return leaseOrders;
        }
    }
}
