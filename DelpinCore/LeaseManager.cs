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

        //dummy method, doesn't do anything yet
        public void ReadLease(int leaseID)
        {

        }

        //Method to delete a Lease
        public string DeleteLease(int leaseID)
        {
            //sql to delete all LeaseOrders from the Lease
            string deleteLeaseOrders = $"delete from LeaseOrder where LeaseID = {leaseID}";

            //sql to delete the Lease
            string deleteLease = $"delete from Lease where LeaseID = {leaseID}";

            //send sql to delete LeaseOrders
            string isDeleteLeaseOrderSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(deleteLeaseOrders);

            //if deletion of LeaseOrders was not a success return the error message
            if (isDeleteLeaseOrderSuccess != "success")
            {
                return isDeleteLeaseOrderSuccess;
            }

            //send sql to delete Lease
            string isDeleteLeaseSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(deleteLease);
            
            //if deletion of LeaseOrders was not a success return the error message
            if (isDeleteLeaseSuccess != "success")
            {
                return isDeleteLeaseSuccess;
            }

            //if everything went right, return message that Lease was deleted
            return $"Lejekontrakt {leaseID} er blevet slettet";
        }

        //dummy method, doesn't do anything yet
        public void CreateLease(int debtorID)
        {
            activeLease = new Lease(debtorID);
        }

        //dummy method, doesn't do anything yet
        public void AddLeaseOrderToLease(LeaseOrder leaseOrder)
        {
            activeLease.AddLeaseOrder(leaseOrder);
        }
    }
}
