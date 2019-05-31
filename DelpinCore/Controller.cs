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
        ModelManager modelManager = new ModelManager();
        LeaseManager leaseManager = new LeaseManager();
        AccessoryManager accessoryManager = new AccessoryManager();
        TableDisplay tableDisplay = new TableDisplay();
        DeliveryManager deliveryManager = new DeliveryManager();
        Invoice invoice = new Invoice();
        BranchManager branchManager = new BranchManager();

        public string ReadDebtor()
        {
            string readDebtor = debtorManager.ReadDebtor();
            return readDebtor;
        }

        public string CreatePersonalDebtor(string debtorID, string street, int postalCode, string city, string phone, string email, string CPR, string firstName, string lastName)
        {
            string createPersonalDebtor = debtorManager.CreatePersonalDebtor(debtorID, street, postalCode, city, phone, email, CPR, firstName, lastName);
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
            string updatePersonalDebtor = debtorManager.UpdatePersonalDebtor(debtorID, street, postalCode, city, phone, email, CPR, firstName, lastName);
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

        public string CreateResource(int resourceID, int modelID, int branchID)
        {
            string createResource = resourceManager.CreateResource(resourceID, modelID, branchID);
            return createResource;
        }

        public string ReadResource()
        {
            string readResource = resourceManager.ReadResource();
            return readResource;
        }

        public string UpdateResource(int resourceID, int modelID, int branchID)
        {
            string updateResource = resourceManager.UpdateResource(resourceID, modelID, branchID);
            return updateResource;
        }

        public string DeleteResource(int resourceID)
        {
            string deleteResource = resourceManager.DeleteResource(resourceID);
            return deleteResource;
        }

        public string CreateModel(string modelName, double price, int subGroupID, double weightKG)
        {
            string createModel = modelManager.CreateModel(modelName, price, subGroupID, weightKG);
            return createModel;
        }

        public string ReadModel()
        {
            string readModel = modelManager.ReadModel();
            return readModel;
        }

        public string UpdateModel(int modelID, string modelName, double price, int subGroupID, double weightKG)
        {
            string updateModel = modelManager.UpdateModel(modelID, modelName, price, subGroupID, weightKG);
            return updateModel;
        }

        public string DeleteModel(int modelID)
        {
            string deleteModel = modelManager.DeleteModel(modelID);
            return deleteModel;
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

        public string UpdateLeaseStatus(string status, int leaseID)
        {
            string isSuccess = leaseManager.UpdateStatus(status, leaseID);
            return isSuccess;
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

        public string CreateAccessory(int modelID, int accessoryID)
        {
            string createAccessory = accessoryManager.CreateAccessory(modelID, accessoryID);
            return createAccessory;
        }

        public DataTable ReadAccessory(int modelID)
        {
            DataTable readAccessory = accessoryManager.ReadAccessory(modelID);
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

        public double GetItemsFromDeliveryTable(int zone, bool ton)
        {
            double deliveryPrice = deliveryManager.GetItemsFromDeliveryTable(zone, ton);
            return deliveryPrice;
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
        public DataTable DisplayModelBySubgroupID(int ModelID)
        {
            DataTable dataTable = tableDisplay.DisplayModelBySubgroupID(ModelID);
            return dataTable;
        }
        public DataTable DisplayBranch()
        {
            DataTable dataTable = tableDisplay.DisplayBranch();
            return dataTable;
        }
        public DataTable DisplayAllResources()
        {
            DataTable dataTable = tableDisplay.DisplayAllResources();
            return dataTable;
        }
        public DataTable DisplayModel()
        {
            DataTable dataTable = tableDisplay.DisplayModel();
            return dataTable;
        }
        public DataTable SelectSpecificModel(int ModelID)
        {
            DataTable dataTable = new DataTable();
            dataTable = tableDisplay.DisplaySpecificModel(ModelID);
            return dataTable;
        }
        public DataTable DisplayAccModel()
        {
            DataTable dataTable = tableDisplay.DisplayAccModel();
            return dataTable;
        }

        public string MakePDF(int LeaseID)
        {
            Lease lease = leaseManager.ReadLeaseByLeaseID(LeaseID);
            Business business = debtorManager.ReadAllDebtorsByDebtorID(lease.debtorID);

            string pdfResult = invoice.MakePDF(lease,business);

            return pdfResult;
        }

        public DataTable ReadAllBranches()
        {
            DataTable dataTable = branchManager.ReadAllBranches();
            return dataTable;
        }

        public Branch ReadBranchByBranchID(int branchID)
        {
            Branch branch = branchManager.ReadBranchByBranchID(branchID);

            return branch;
        }

        public DataTable ReadOnlyAccessory()
        {
            DataTable readOnlyAccessory = accessoryManager.ReadOnlyAccessory();
            return readOnlyAccessory;
        }

        public DataTable DisplayDeliveriesforNextNDays(int branchID, int daysInFuture)
        {
            DataTable dataTable = tableDisplay.DisplayDeliveriesforNextNDays(branchID, daysInFuture);
            return dataTable;
        }

        public DataTable DisplaySpecificResources(int resourceID)
        {
            DataTable dataTable = tableDisplay.DisplaySpecficResources(resourceID);
            return dataTable;
        }
        public DataTable DisplaySpeceficAccesory(int modelID)
        {
            DataTable dataTable = tableDisplay.DisplaySpeceficAccessory(modelID);
            return dataTable;
        }
            }
}
