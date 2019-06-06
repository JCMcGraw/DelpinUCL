using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

namespace DelpinCore
{
    //JC
    class LeaseManager
    {
        public Lease ReadLeaseByLeaseID(int leaseID)
        {
            string selectLeases = $"Select * From Lease Inner Join LeaseOrder On LeaseOrder.LeaseID = Lease.LeaseID join Resources " +
                $"on LeaseOrder.ResourcesID = Resources.ResourcesID join Model on Resources.ModelID = Model.ModelID Where Lease.LeaseID = {leaseID}";


            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectLeases);

            if (dataTable.Rows.Count == 0)
            {
                return new Lease("-1", -1, false);
            }

            Lease lease = ConvertDataTabeToLease(dataTable);

            return lease;
        }

        public DataTable ReadLeasesByDebtorID(string debtorID)
        {
            string selectLeases = "Select Lease.LeaseID As Ordrenummer, Branch.City As Afdeling, Lease.Active As Åben, " +
                "Lease.CreationDate As Dato, Lease.DebtorID As Kundenummer, Lease.ContactFname + ' ' + Lease.ContactLname As Kontakt, Lease.ContactPhone As Kontaktnummer " +
                "From Lease Inner Join Branch On Lease.BranchID = Branch.BranchID " +
                $"Where Lease.DebtorID = '{debtorID}' and Lease.Active = 1 " +
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
            string status = (string)dataTable.Rows[0]["Status"];
            string activeString = (string)dataTable.Rows[0]["Active"];
            bool active = true;
            if (activeString == "0") active = false;

            Lease lease = new Lease(debtorID, branchID, leaseID, creationDate, active);

            try
            {
                string contactFirstName = (string)dataTable.Rows[0]["ContactFname"];
                string contactLastName = (string)dataTable.Rows[0]["ContactLname"];
                string contactPhone = (string)dataTable.Rows[0]["ContactPhone"];

                lease.SetContactDetails(contactFirstName, contactLastName, contactPhone);
            }
            catch { }

            lease.SetStatus(status);

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
                decimal deliveryPrice = Convert.ToDecimal(dataRow["DeliveryPrice"]);

                leaseOrder.SetDeliveryAddress(deliveryStreet, deliveryPostalCode, deliveryCity, deliveryPrice);
                leaseOrder.SetModelName(dataRow["ModelName"].ToString());
                
                lease.AddLeaseOrder(leaseOrder);
            }

            return lease;
        }

        //inserts new Lease in database
        public string CreateLease(Lease lease)
        {
            string active = "1";
            if (lease.active == false) { active = "0"; }

            string insertLease = $"insert into Lease (CreationDate, Active, DebtorID, BranchID, ContactFname, ContactLname, ContactPhone, Status) output inserted.LeaseID " +
                $"Values (CONVERT (date, CURRENT_TIMESTAMP), {active}, '{lease.debtorID}', {lease.branchID}, '{lease.contactFirstName.Replace("'","''")}'," +
                $" '{lease.contactLastName.Replace("'", "''")}', '{lease.contactPhone.Replace("'","''")}', '{lease.status}')";

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
            string insertLeaseOrder = $"insert into LeaseOrder (StartDate, EndDate, LeasePrice, ResourcesID, LeaseID, DeliveryStreet, DeliveryPostalCode, DeliveryCity, DeliveryPrice)\nvalues\n";

            for (int i = 0; i < lease.GetLeaseOrders().Count; i++)
            {
                LeaseOrder lo = lease.GetLeaseOrders()[i];
                if (i != 0)
                {
                    insertLeaseOrder += ", ";
                }
                insertLeaseOrder += $"('{lo.startDate.ToString("yyyy-MM-dd")}', '{lo.endDate.ToString("yyyy-MM-dd")}', {lo.leasePrice.ToString("G", new CultureInfo("en-US"))}," +
                    $" {lo.resourceID}, {lease.leaseID}, '{lo.deliveryStreet.Replace("'", "''")}', {lo.deliveryPostalCode}, '{lo.deliveryCity.Replace("'", "''")}', {lo.deliveryPrice.ToString("G", new CultureInfo("en-US"))})";
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
            string updateLease = $"update Lease set ContactFname = '{lease.contactFirstName.Replace("'", "''")}', ContactLname = '{lease.contactLastName.Replace("'", "''")}', " +
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

        public string DeactivateLease(int leaseID)
        {
            string deactivateLease = $"update Lease set Lease.Active = 0 where LeaseID = {leaseID}";
            string isSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(deactivateLease);
            return isSuccess;
        }

        public string ReactivateLease(int leaseID)
        {
            string deactivateLease = $"update Lease set Lease.Active = 1 where LeaseID = {leaseID}";
            string isSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(deactivateLease);
            return isSuccess;
        }

        public DataTable GetAvailableResourcesForPeriod(int modelID, int BranchID, string startDate, string endDate)
        {
            string sql = GetAvailabilitySQL(modelID, BranchID, startDate, endDate);
            DataTable dataTable = DatabaseManager.ReadFromDatabase(sql);
            return dataTable;
        }

        private string GetAvailabilitySQL(int modelID, int branchID, string startDate, string endDate)
        {
            string sql = $"Select " +
            $"    Resources.ResourcesID as [ResurseID], " +
            $"    Model.ModelName as [Model], " +
            $"    Model.Price as [Dagspris], " +
            $"	Case " +
            $"		When ResourceAvailability.Tilgængelighed IS NULL then 'Fri' " +
            $"		else ResourceAvailability.Tilgængelighed " +
            $"	end as Tilgængelighed, " +
            $"	Branch.City as Lokation, " +
            $"	Distance.DistanceKm as [Distance], " +
            $"	Case " +
            $"		When ResourceAvailability.DatesBooked IS NULL then '' " +
            $"		else ResourceAvailability.DatesBooked " +
            $"	end as [Datoer udlejet] " +
            $"From " +
            $"    Resources Inner Join " +
            $"    Model On Resources.ModelID = Model.ModelID left join " +
            $"(select TestDates.ResourcesID, TestDates.Tilgængelighed, STRING_AGG(CONVERT(varchar, TestDates.StartDate, 3) + ' - ' + CONVERT(varchar, TestDates.EndDate, 3), ', ') " +
            $"WITHIN GROUP (ORDER BY TestDates.StartDate) AS DatesBooked  from " +
            $"(Select " +
            $"    LeaseOrder.ResourcesID, " +
            $"    LeaseOrder.StartDate, " +
            $"    LeaseOrder.EndDate, " +
            $"    Case " +
            $"        When LeaseOrder.StartDate <= '{startDate}' And LeaseOrder.EndDate >= '{endDate}' " +
            $"        Then 'Ikke fri' " +
            //$"        When LeaseOrder.StartDate Between '{startDate}' And '{endDate}' Or " +
            //$"            LeaseOrder.EndDate Between '{startDate}' And '{endDate}' " +
            $"        When (LeaseOrder.StartDate >= '{startDate}' And LeaseOrder.StartDate < '{endDate}') Or " +
            $"            (LeaseOrder.EndDate > '{startDate}' And LeaseOrder.EndDate <= '{endDate}') " +
            $"        Then 'Ikke fri' " +
            $"        Else 'Fri' " +
            $"    End As Tilgængelighed " +
            $"From " +
            $"    LeaseOrder Inner Join " +
            $"    Resources On LeaseOrder.ResourcesID = Resources.ResourcesID Inner Join " +
            $"    Model On Resources.ModelID = Model.ModelID " +
            $"Where " +
            $"    Model.ModelID = {modelID} and ((LeaseOrder.StartDate <= '{startDate}' And " +
            $"            LeaseOrder.EndDate >= '{endDate}') Or " +
            //$"        LeaseOrder.StartDate Between '{startDate}' And '{endDate}' Or " +
            //$"        LeaseOrder.EndDate Between '{startDate}' And '{endDate}')) as TestDates " +
            $"        (LeaseOrder.StartDate >= '{startDate}' And LeaseOrder.StartDate < '{endDate}') Or " +
            $"        (LeaseOrder.EndDate > '{startDate}' And LeaseOrder.EndDate <= '{endDate}'))) as TestDates " +
            $"Group by TestDates.ResourcesID, TestDates.Tilgængelighed) as ResourceAvailability " +
            $"	on ResourceAvailability.ResourcesID = Resources.ResourcesID join " +
            $"	Branch on Branch.BranchID = Resources.BranchID join Distance on Resources.BranchID = Distance.EndLocation  " +
            $"	and Distance.StartLocation = {branchID} " +
            $"	where Model.ModelID = {modelID} " +
            $"  and Resources.Active = '1'" +
            $"	order by Tilgængelighed, Distance; ";

            return sql;
        }

        public string UpdateLeaseStatus(string status, int leaseID)
        {
            string updateStatus = $"update Lease set Status = '{status}' where leaseID = {leaseID}";
            string isSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(updateStatus);

            return isSuccess;
        }
    }
}
