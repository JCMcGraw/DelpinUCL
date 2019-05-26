using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DelpinCore
{
    public class Controller
    {
        DebtorManager debtorManager = new DebtorManager();
        ResourceManager resourceManager = new ResourceManager();
        LeaseManager leaseManager = new LeaseManager();
        AccessoryManager accessoryManager = new AccessoryManager();
        TableDisplay tableDisplay = new TableDisplay();
        DeliveryManager deliveryManager = new DeliveryManager();

        public string ReadDebtor()
        {
            string readDebtor = debtorManager.ReadDebtor();
            return readDebtor;
        }

        public string CreatePersonalDebtor(string debtorID, string street, int postalCode, string city, string phone, string email, string CPR, string firstName, string lastName)
        {
            string createPersonalDebtor = debtorManager.CreatePersonalDebtor(debtorID, street, postalCode, city, phone, email, CPR,firstName,lastName);
            return createPersonalDebtor;
        }

        public DataTable ReadPersonalDebtor(string debtorID)
        {
            DataTable dataTable = new DataTable();
            dataTable = debtorManager.ReadPersonalDebtor(debtorID);
            return dataTable;
        }
        public DataTable SelectSpecificBusiness(string debtorID)
        {
            DataTable dataTable = new DataTable();
            dataTable = tableDisplay.DisplaySpeceficBusinessDebtor(debtorID);
            return dataTable;
        }
        public DataTable SelectAllBusiness()
        {
            DataTable dataTable = new DataTable();
            dataTable = tableDisplay.DisplayAllBusinessDebtor();
            return dataTable;
        }
        public DataTable SelectAllPersonal()
        {
            DataTable dataTable = new DataTable();
            dataTable = tableDisplay.DisplayAllPersonalDebtor();
            return dataTable;
        }
        public DataTable SelectSpecificPersonal(string debtorID)
        {
            DataTable dataTable = new DataTable();
            dataTable = tableDisplay.DisplaySpeceficPersonalDebtor(debtorID);
            return dataTable;
        }

        public string UpdatePersonalDebtor(string debtorID, string street, int postalCode, string city, string phone, string email, string CPR, string firstName, string lastName)
        {
            string updatePersonalDebtor = debtorManager.UpdatePersonalDebtor(debtorID, street, postalCode, city, phone, email, CPR,firstName,lastName);
            return updatePersonalDebtor;
        }

        public string DeletePersonalDebtor(string debtorID)
        {
            string deletePersonalDebtor = debtorManager.DeletePersonalDebtor(debtorID);
            return deletePersonalDebtor;
        }

        public string CreateBusinessDebtor(string debtorID, string street, int postalCode, string city, string phone, string email, string CVR, string companyName)
        {
            string createBusinessDebtor = debtorManager.CreateBusinessDebtor(debtorID, street, postalCode, city, phone, email, CVR, companyName);
            return createBusinessDebtor;
        }

        public DataTable ReadBusinessDebtor(string debtorID)
        {
            DataTable dataTable = new DataTable();
            dataTable = debtorManager.ReadBusinessDebtor(debtorID);

            return dataTable;
        }

        public string UpdateBusinessDebtor(string debtorID, string street, int postalCode, string city, string phone, string email, string CVR, string companyName)
        {
            string updateBusinessDebtor = debtorManager.UpdateBusinessDebtor(debtorID, street, postalCode, city, phone, email, CVR, companyName);
            return updateBusinessDebtor;
        }

        public string DeleteBusinessDebter(string debtorID)
        {
            string deleteBusinessDebter = debtorManager.DeleteBusinessDebtor(debtorID);
            return deleteBusinessDebter;
        }

        public string CreateResource(int resourceID, int modelID, int branchID, string modelName, double price, int subGroupID)
        {
            string createResource = resourceManager.CreateResource(resourceID, modelID, branchID,modelName,price,subGroupID);
            return createResource;
        }

        public string ReadResource()
        {
            string readResource = resourceManager.ReadResource();
            return readResource;
        }

        public string UpdateResource(int resourceID, int modelID, int branchID, string modelName, double price, int subGroupID)
        {
            string updateResource = resourceManager.UpdateResource(resourceID, modelID, branchID,modelName,price,subGroupID);
            return updateResource;
        }

        public string DeleteResource(int resourceID,int modelID)
        {
            string deleteResource = resourceManager.DeleteResource(resourceID,modelID);
            return deleteResource;
        }

        public void DeleteLease(int leaseID)
        {
            leaseManager.DeleteLease(leaseID);
        }

        public string DeactivateLease(int leaseID)
        {
            string deactivateSuccess = leaseManager.DeactivateLease(leaseID);
            return deactivateSuccess;
        }

        public string CreateLease(Lease lease)
        {
            string leaseSuccess = leaseManager.CreateLease(lease);
            return leaseSuccess;
        }

        public string UpdateLease(Lease lease)
        {
            string isUpdateSuccess = leaseManager.UpdateLease(lease);
            return isUpdateSuccess;
        }
        
        public DataTable ReadLeasesByDebtor(string debtorID)
        {
            DataTable dataTable = new DataTable();
            dataTable = leaseManager.ReadLeasesByDebtorID(debtorID);

            return dataTable;
        }

        public Lease ReadLeaseByLeaseID(int leaseID)
        {
            Lease lease = leaseManager.ReadLeaseByLeaseID(leaseID);

            return lease;
        }

        public DataTable GetAvailableResourcesForPeriod(int modelID, int branchID, string startDate, string endDate)
        {
            DataTable dataTable = leaseManager.GetAvailableResourcesForPeriod(modelID, branchID, startDate, endDate);
            return dataTable;
        }

        public string CreateAccessory(int accessoryModelID, string modelID, string accessoryID)
        {
            string createAccessory = accessoryManager.CreateAccessory(accessoryModelID, modelID, accessoryID);
            return createAccessory;
        }

        public string ReadAccessory()
        {
            string readAccessory = accessoryManager.ReadAccessory();
            return readAccessory;
        }

        public string DeleteAccessory(int accessoryModelID)
        {
            string deleteAccessory = accessoryManager.DeleteAccessory(accessoryModelID);
            return deleteAccessory;
        }

        public DataTable ReadSpecefikSubCataegori(int subGroupID)
        {
            DataTable dataTable = new DataTable();
            dataTable = resourceManager.ReadSpecefikSubCataegori(subGroupID);

            return dataTable;
        }

        public DataTable ReadSpecefikModelResourcesBranch(int resurceID)
        {
            DataTable dataTable = new DataTable();
            dataTable = resourceManager.ReadSpecefikModelResourcesBranch(resurceID);

            return dataTable;
        }

        public double DeliveryPrice(int zone, double weight, int km, double deliveryPrice)
        {
            double deliveryPrices = deliveryManager.DeliveryPrice(zone, true, km, deliveryPrice);
            return deliveryPrices;
        }

        public DataTable GetMainGroup()
        {
            DataTable dataTable = tableDisplay.DisplayMainGroup();
            return dataTable;
        }

        public DataTable GetSubGroup()
        {
            DataTable dataTable = tableDisplay.DisplaySubGroup();
            return dataTable;
        }
    }
}
