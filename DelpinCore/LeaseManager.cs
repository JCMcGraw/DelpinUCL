using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DelpinCore
{
    class LeaseManager
    {
        public DataTable ReadLeasesByDebtor(int debtorID)
        {
            string selectLeases = $"Select * From Lease Where Lease.DebtorID = {debtorID}";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectLeases);

            return dataTable;
        }

        public DataTable ReadLeaseByLeaseID(int leaseID)
        {
            string selectLeases = $"Select * From Lease Inner Join LeaseOrder On LeaseOrder.LeaseID = Lease.LeaseID Where Lease.LeaseID = {leaseID}";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectLeases);

            return dataTable;
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
            if (isDeleteLeaseOrderSuccess != "Success")
            {
                return isDeleteLeaseOrderSuccess;
            }

            //send sql to delete Lease
            string isDeleteLeaseSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(deleteLease);
            
            //if deletion of LeaseOrders was not a success return the error message
            if (isDeleteLeaseSuccess != "Success")
            {
                return isDeleteLeaseSuccess;
            }

            //if everything went right, return message that Lease was deleted
            return $"Lejekontrakt {leaseID} er blevet slettet";
        }

        //inserts new Lease in database
        public string CreateLease(Lease lease)
        {
            string insertLease = $"insert into Lease (CreationDate, Active, DebtorID, BranchID, ContactFname, ContactLname, ContactPhone) output inserted.LeaseID " +
                $"Values (CONVERT (date, CURRENT_TIMESTAMP), 1, {lease.debtorID}, {lease.branchID}, '{lease.contactFirstName}', '{lease.contactLastName}', '{lease.contactPhone}')";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(insertLease);

            int leaseID = (int)dataTable.Rows[0][0];

            lease.SetLeaseID(leaseID);

            string insertLeaseOrder = GetLeaseOrderInsertString(lease);

            string isInsertSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(insertLeaseOrder);

            return leaseID.ToString() + ";" + isInsertSuccess;
        }

        //create insertstring for leaseorders
        private string GetLeaseOrderInsertString(Lease lease)
        {
            string insertLeaseOrder = $"insert into LeaseOrder (StartDate, EndDate, LeasePrice, ResourcesID, LeaseID, DeliveryStreet, DeliveryPostalCode, DeliveryCity)\nvalues\n";

            for (int i = 0; i < lease.GetLeaseOrders().Count; i++)
            {
                LeaseOrder lo = lease.GetLeaseOrders()[i];
                if (i != 0)
                {
                    insertLeaseOrder += ", ";
                }
                insertLeaseOrder += $"('{lo.startDate.ToString("yyyy-MM-dd")}', '{lo.endDate.ToString("yyyy-MM-dd")}', {lo.leasePrice}," +
                    $" {lo.resourceID}, {lease.leaseID}, '{lo.deliveryStreet}', {lo.deliveryPostalCode}, '{lo.deliveryCity}')";
            }
            return insertLeaseOrder;
        }

        public string UpdateLeaseOrdersOnLease(Lease lease)
        {
            string deleteLeaseOrders = $"delete from LeaseOrder where LeaseID = {lease.leaseID}";

            string isDeleteSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(deleteLeaseOrders);

            string insertLeaseOrder = GetLeaseOrderInsertString(lease);

            string isInsertSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(insertLeaseOrder);

            return isInsertSuccess;

        }

    }
}
