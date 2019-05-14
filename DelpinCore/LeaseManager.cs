using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class LeaseManager
    {
        private Lease activeLease;

        public void ReadLease(int leaseID)
        {

        }

        public void DeleteLease(int leaseID)
        {

        }

        public void CreateLease(int debtorID)
        {
            activeLease = new Lease(debtorID);
        }

        public void AddLeaseOrderToLease(LeaseOrder leaseOrder)
        {
            activeLease.AddLeaseOrder(leaseOrder);
        }
    }
}
