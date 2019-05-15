﻿using System;
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
        public DateTime dateCreated { get; private set; }
        private List<LeaseOrder> leaseOrders = new List<LeaseOrder>();

        public Lease(int debtorID)
        {
            this.debtorID = debtorID;
            this.dateCreated = DateTime.Now;
        }

        public Lease(int debtorID, int leaseID, DateTime dateCreated)
        {
            this.leaseID = leaseID;
            this.debtorID = debtorID;
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

        public List<LeaseOrder> GetLeaseOrders()
        {
            return leaseOrders;
        }
    }
}