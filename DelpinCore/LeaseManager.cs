﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DelpinCore
{
    class LeaseManager
    {
        public Lease ReadLeaseByLeaseID(int leaseID)
        {
            string selectLeases = $"Select * From Lease Inner Join LeaseOrder On LeaseOrder.LeaseID = Lease.LeaseID join Resources " +
                $"on LeaseOrder.ResourcesID = Resources.ResourcesID join Model on Resources.ModelID = Model.ModelID Where Lease.LeaseID = {leaseID}";


            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectLeases);

            Lease lease = ConvertDataTabeToLease(dataTable);

            return lease;
        }

        public DataTable ReadLeasesByDebtorID(string debtorID)
        {
            string selectLeases = "Select Lease.LeaseID As Ordrenummer, Branch.City As Afdeling, Lease.Active As Åben, " +
                "Lease.CreationDate As Dato, Lease.DebtorID As Kundenummer, Lease.ContactFname + ' ' + Lease.ContactLname As Kontakt, Lease.ContactPhone As Kontaktnummer " +
                "From Lease Inner Join Branch On Lease.BranchID = Branch.BranchID " +
                "Where Lease.DebtorID = '33333333' " +
                "Order By Lease.CreationDate Desc";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectLeases);
            return dataTable;
        }

        private Lease ConvertDataTabeToLease(DataTable dataTable)
        {
            int leaseID = Convert.ToInt32(dataTable.Rows[0]["LeaseID"]);
            int branchID = Convert.ToInt32(dataTable.Rows[0]["BranchID"]);
            DateTime creationDate = Convert.ToDateTime(dataTable.Rows[0]["CreationDate"]);
            string debtorID = (string)dataTable.Rows[0]["DebtorID"];

            Lease lease = new Lease(debtorID, branchID, leaseID, creationDate);

            string contactFirstName = (string)dataTable.Rows[0]["ContactFname"];
            string contactLastName = (string)dataTable.Rows[0]["ContactLname"];
            string contactPhone = (string)dataTable.Rows[0]["ContactPhone"];

            lease.SetContactDetails(contactFirstName, contactLastName, contactPhone);

            foreach(DataRow dataRow in dataTable.Rows)
            {
                DateTime startDate = Convert.ToDateTime(dataRow["StartDate"]);
                DateTime endDate = Convert.ToDateTime(dataRow["EndDate"]);
                int resourcesID = Convert.ToInt32(dataRow["ResourcesID"]);
                decimal leasePrice = Convert.ToDecimal(dataRow["LeasePrice"]);

                LeaseOrder leaseOrder = new LeaseOrder(startDate, endDate, leasePrice, resourcesID);

                string deliveryStreet = dataRow["DeliveryStreet"].ToString();
                int deliveryPostalCode = Convert.ToInt32(dataRow["DeliveryPostalCode"]);
                string deliveryCity = dataRow["DeliveryCity"].ToString();

                leaseOrder.SetDeliveryAddress(deliveryStreet, deliveryPostalCode, deliveryCity);
                leaseOrder.SetModelName(dataRow["ModelName"].ToString());
                
                lease.AddLeaseOrder(leaseOrder);
            }

            return lease;
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

        public string UpdateLease(Lease lease)
        {
            string isUpdateLeaseTableSuccess = UpdateLeaseTable(lease);
            if (isUpdateLeaseTableSuccess != "Success")
            {
                return isUpdateLeaseTableSuccess;
            }
            else
            {
                string isUpdateLeaseOrdersSuccess= UpdateLeaseOrdersOnLease(lease);
                return isUpdateLeaseOrdersSuccess;
            }
        }


        private string UpdateLeaseTable(Lease lease)
        {
            string updateLease = $"update Lease set ContactFname = '{lease.contactFirstName}', ContactLname = '{lease.contactLastName}', " +
                $"ContactPhone = '{lease.contactPhone}', DebtorID = '{lease.debtorID}' where LeaseID = {lease.leaseID}";

            string isUpdateSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(updateLease);

            return isUpdateSuccess;
        }

        private string UpdateLeaseOrdersOnLease(Lease lease)
        {
            string deleteLeaseOrders = $"delete from LeaseOrder where LeaseID = {lease.leaseID}";

            string isDeleteSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(deleteLeaseOrders);
            if (isDeleteSuccess != "Success")
            {
                return isDeleteSuccess;
            }

            string insertLeaseOrder = GetLeaseOrderInsertString(lease);

            string isInsertSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(insertLeaseOrder);

            return isInsertSuccess;

        }

        public DataTable GetAvailableResourcesForPeriod(int modelID)
        {
            string sql = GetAvailabilitySQL(modelID);
            DataTable dataTable = DatabaseManager.ReadFromDatabase(sql);
            return dataTable;
        }

        private string GetAvailabilitySQL(int modelID)
        {
            string sql = $"Select " +
            $"    Resources.ResourcesID as [ResurseID], " +
            $"    Model.ModelName as [Model], " +
            $"	Case " +
            $"		When ResourceAvailability.Tilgængelighed IS NULL then 'fri' " +
            $"		else ResourceAvailability.Tilgængelighed " +
            $"	end as Tilgængelighed, " +
            $"	Branch.City as Lokation, " +
            $"	Distance.DistanceKm as [Distance] " +
            $"From " +
            $"    Resources Inner Join " +
            $"    Model On Resources.ModelID = Model.ModelID left join " +
            $"(Select " +
            $"    LeaseOrder.ResourcesID, " +
            $"    LeaseOrder.StartDate, " +
            $"    LeaseOrder.EndDate, " +
            $"    Case " +
            $"        When LeaseOrder.StartDate <= '2019-07-01' And LeaseOrder.EndDate >= '2019-07-03' " +
            $"        Then 'Ikke fri' " +
            $"        When LeaseOrder.StartDate Between '2019-07-01' And '2019-07-03' Or " +
            $"            LeaseOrder.EndDate Between '2019-07-01' And '2019-07-03' " +
            $"        Then 'Fri nogle dage' " +
            $"        Else 'fri' " +
            $"    End As Tilgængelighed " +
            $"From " +
            $"    LeaseOrder Inner Join " +
            $"    Resources On LeaseOrder.ResourcesID = Resources.ResourcesID Inner Join " +
            $"    Model On Resources.ModelID = Model.ModelID " +
            $"Where " +
            $"    Model.ModelID = {modelID} and ((LeaseOrder.StartDate <= '2019-07-01' And " +
            $"            LeaseOrder.EndDate >= '2019-07-03') Or " +
            $"        LeaseOrder.StartDate Between '2019-07-01' And '2019-07-03' Or " +
            $"        LeaseOrder.EndDate Between '2019-07-01' And '2019-07-03')) as ResourceAvailability " +
            $"	on ResourceAvailability.ResourcesID = Resources.ResourcesID join " +
            $"	Branch on Branch.BranchID = Resources.BranchID join Distance on Resources.BranchID = Distance.EndLocation  " +
            $"	and Distance.StartLocation = 1 " +
            $"	where Model.ModelID = {modelID} " +
            $"	order by Tilgængelighed, Distance; ";

            return sql;
        }

    }
}
