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

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Debtor
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

        //--------------------------------------------------------------------------------------------------------------------------------------
        //TableDisplay
        public DataTable DisplaySpeceficBusinessDebtor(string debtorID)
        {
            DataTable dataTable = new DataTable();
            dataTable = debtorManager.DisplaySpeceficBusinessDebtor(debtorID);
            return dataTable;
        }

        public DataTable DisplaySpeceficPersonalDebtor(string debtorID)
        {
            DataTable dataTable = new DataTable();
            dataTable = debtorManager.DisplaySpeceficPersonalDebtor(debtorID);
            return dataTable;
        }

        public DataTable DisplayAllBusinessDebtor()
        {
            DataTable dataTable = new DataTable();
            dataTable = debtorManager.DisplayAllBusinessDebtor();
            return dataTable;
        }

        public DataTable DisplayAllPersonalDebtor()
        {
            DataTable dataTable = new DataTable();
            dataTable = debtorManager.DisplayAllPersonalDebtor();
            return dataTable;
        }

        public DataTable DisplayAllResources()
        {
            DataTable dataTable = resourceManager.DisplayAllResources();
            return dataTable;
        }

        public DataTable DisplaySpecificResources(int resourceID)
        {
            DataTable dataTable = resourceManager.DisplaySpecficResources(resourceID);
            return dataTable;
        }

        public DataTable DisplayMainGroup()
        {
            DataTable dataTable = tableDisplay.DisplayMainGroup();
            return dataTable;
        }

        public DataTable DisplaySubGroup()
        {
            DataTable dataTable = tableDisplay.DisplaySubGroup();
            return dataTable;
        }

        public DataTable DisplayBranch()
        {
            DataTable dataTable = branchManager.DisplayBranch();
            return dataTable;
        }

        public DataTable DisplayModelBySubgroupID(int ModelID)
        {
            DataTable dataTable = modelManager.DisplayModelBySubgroupID(ModelID);
            return dataTable;
        }

        public DataTable DisplayModel()
        {
            DataTable dataTable = modelManager.DisplayModel();
            return dataTable;
        }

        public DataTable DisplayAccModel()
        {
            DataTable dataTable = tableDisplay.DisplayAccModel();
            return dataTable;
        }

        public DataTable DisplaySpecificModel(int ModelID)
        {
            DataTable dataTable = new DataTable();
            dataTable = modelManager.DisplaySpecificModel(ModelID);
            return dataTable;
        }

        public DataTable DisplayAccesoryRelations()
        {
            DataTable dataTable = new DataTable();
            dataTable = accessoryManager.DisplayAccesoryRelations();
            return dataTable;
        }

        public DataTable DisplayAccessoryRelationsBySubGroupID(int subGroupID)
        {
            DataTable dataTable = new DataTable();
            dataTable = accessoryManager.DisplayAccesoryRelationsBySubGroupID(subGroupID);
            return dataTable;
        }

        public DataTable DisplayDeliveriesforNextNDays(int branchID, int daysInFuture)
        {
            DataTable dataTable = tableDisplay.DisplayDeliveriesforNextNDays(branchID, daysInFuture);
            return dataTable;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //Resource 
        public string CreateResource(int resourceID, int modelID, int branchID)
        {
            string createResource = resourceManager.CreateResource(resourceID, modelID, branchID);
            return createResource;
        }

        public string DeactivateResource(int resourceID)
        {
            string deactivateResource = resourceManager.DeactivateResource(resourceID);
            return deactivateResource;
        }

        public DataTable ReadSpecefikSubCataegori(int subGroupID)
        {
            DataTable dataTable = new DataTable();
            dataTable = modelManager.ReadSpecefikSubCataegori(subGroupID);

            return dataTable;
        }

        //Denne bliver ikke brugt
        public DataTable ReadSpecefikModelResourcesBranch(int resurceID)
        {
            DataTable dataTable = new DataTable();
            dataTable = resourceManager.ReadSpecefikModelResourcesBranch(resurceID);

            return dataTable;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //Model
        public string CreateModel(string modelName, double price, int subGroupID, double weightKG)
        {
            string createModel = modelManager.CreateModel(modelName, price, subGroupID, weightKG);
            return createModel;
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
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //Lease
        public Lease ReadLeaseByLeaseID(int leaseID)
        {
            Lease lease = leaseManager.ReadLeaseByLeaseID(leaseID);

            return lease;
        }

        public DataTable ReadLeasesByDebtorID(string debtorID) //Denne Hedder ikke det samme som den gør i LeaseManager
        {
            DataTable dataTable = new DataTable();
            dataTable = leaseManager.ReadLeasesByDebtorID(debtorID);

            return dataTable;
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

        public string DeactivateLease(int leaseID)
        {
            string deactivateSuccess = leaseManager.DeactivateLease(leaseID);
            return deactivateSuccess;
        }

        public string ReactivateLease(int leaseID)
        {
            string reactivateSuccess = leaseManager.ReactivateLease(leaseID);
            return reactivateSuccess;
        }

        public DataTable GetAvailableResourcesForPeriod(int modelID, int branchID, string startDate, string endDate)
        {
            DataTable dataTable = leaseManager.GetAvailableResourcesForPeriod(modelID, branchID, startDate, endDate);
            return dataTable;
        }

        public string UpdateLeaseStatus(string status, int leaseID)
        {
            string isSuccess = leaseManager.UpdateLeaseStatus(status, leaseID);
            return isSuccess;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //Accessory 
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
        //------------------------------------------------------------------------------------------------------------------------------------------------------------------

        //Delivery
        public double GetItemsFromDeliveryTable(int zone, bool ton)
        {
            double deliveryPrice = deliveryManager.GetItemsFromDeliveryTable(zone, ton);
            return deliveryPrice;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------

        //Invoice
        public string MakePDF(int LeaseID)
        {
            Lease lease = leaseManager.ReadLeaseByLeaseID(LeaseID);
            Business business = debtorManager.ReadAllDebtorsByDebtorID(lease.debtorID);
            Personal personal = debtorManager.ReadAllPersonalDebtorsByDebtorID(lease.debtorID);

            string pdfResult = invoice.MakePDF(lease,business,personal);

            return pdfResult;
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------

        //Branch 
        //De bliver ikke brugt
        public DataTable ReadAllBranches()
        {
            DataTable dataTable = branchManager.ReadAllBranches();
            return dataTable;
        }

        //Denne bliver ikke brugt
        public Branch ReadBranchByBranchID(int branchID)
        {
            Branch branch = branchManager.ReadBranchByBranchID(branchID);
            return branch;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------
    }
}
