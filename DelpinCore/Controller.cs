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

        public DataTable ReadPersonalDebtor(int debtorID)
        {
            DataTable dataTable = new DataTable();
            dataTable = debtorManager.ReadPersonalDebtor(debtorID);
            return dataTable;
        }

        public string UpdatePersonalDebtor(string debtorID, string street, int postalCode, string city, string phone, string email, string CPR, string firstName, string lastName)
        {
            string updatePersonalDebtor = debtorManager.UpdatePersonalDebtor(debtorID, street, postalCode, city, phone, email, CPR,firstName,lastName);
            return updatePersonalDebtor;
        }

        public string DetetePersonalDebtor(string debtorID)
        {
            string deletePersonalDebtor = debtorManager.DeletePersonalDebtor(debtorID);
            return deletePersonalDebtor;
        }

        public string CreateBusinessDebtor(string debtorID, string street, int postalCode, string city, string phone, string email, string CVR, string companyName, string contactFname, string contactPhone)
        {
            string createBusinessDebtor = debtorManager.CreateBusinessDebtor(debtorID, street, postalCode, city, phone, email, CVR, companyName, contactFname, contactPhone);
            return createBusinessDebtor;
        }

        public DataTable ReadBusinessDebtor(int debtorID)
        {
            DataTable dataTable = new DataTable();
            dataTable = debtorManager.ReadBusinessDebtor(debtorID);

            return dataTable;
        }

        public string UpdateBusinessDebtor(string debtorID, string street, int postalCode, string city, string phone, string email, string CVR, string companyName, string contactFname, string contactPhone)
        {
            string updateBusinessDebtor = debtorManager.UpdateBusinessDebtor(debtorID, street, postalCode, city, phone, email, CVR, companyName, contactFname, contactPhone);
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

        public void CreateLease(Lease lease)
        {
            leaseManager.CreateLease(lease);
        }

        public void UpdateLeaseOrdersOnLease(Lease lease)
        {
            leaseManager.UpdateLeaseOrdersOnLease(lease);
        }
        
        public DataTable ReadLeasesByDebtor(int debtorID)
        {
            DataTable dataTable = new DataTable();
            dataTable = leaseManager.ReadLeasesByDebtor(debtorID);

            return dataTable;
        }

        public DataTable ReadLeaseByLeaseID(int leaseID)
        {
            DataTable dataTable = new DataTable();
            dataTable = leaseManager.ReadLeaseByLeaseID(leaseID);

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


    }
}
