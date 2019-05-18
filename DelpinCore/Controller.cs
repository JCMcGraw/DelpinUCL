using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class Controller
    {
        DebtorManager debtorManager = new DebtorManager();
        ResourceManager resourceManager = new ResourceManager();

        public string ReadDebtor()
        {
            string readDebtor = debtorManager.ReadDebtor();
            return readDebtor;
        }

        public string CreatePersonalDebtor(int debtorID, string street, int postalCode, string city, string phone, string email, int CPR, string firstName, string lastName)
        {
            string createPersonalDebtor = debtorManager.CreatePersonalDebtor(debtorID, street, postalCode, city, phone, email, CPR,firstName,lastName);
            return createPersonalDebtor;
        }

        public string ReadPersonalDebtor()
        {
            string readPersonalDebtor = debtorManager.ReadPersonalDebtor();
            return readPersonalDebtor;
        }

        public string UpdatePersonalDebtor(int debtorID, string street, int postalCode, string city, string phone, string email, int CPR, string firstName, string lastName)
        {
            string updatePersonalDebtor = debtorManager.UpdatePersonalDebtor(debtorID, street, postalCode, city, phone, email, CPR,firstName,lastName);
            return updatePersonalDebtor;
        }

        public string DetetePersonalDebtor(int debtorID)
        {
            string deletePersonalDebtor = debtorManager.DeletePersonalDebtor(debtorID);
            return deletePersonalDebtor;
        }

        public string CreateBusinessDebtor(int debtorID, string street, int postalCode, string city, string phone, string email, int CVR, string companyName, string contactFname, string contactPhone)
        {
            string createBusinessDebtor = debtorManager.CreateBusinessDebtor(debtorID, street, postalCode, city, phone, email, CVR, companyName, contactFname, contactPhone);
            return createBusinessDebtor;
        }

        public string ReadBusinessDebtor()
        {
            string readBusinessDebtor = debtorManager.ReadBusinessDebtor();
            return readBusinessDebtor;
        }

        public string UpdateBusinessDebtor(int debtorID, string street, int postalCode, string city, string phone, string email, int CVR, string companyName, string contactFname, string contactPhone)
        {
            string updateBusinessDebtor = debtorManager.UpdateBusinessDebtor(debtorID, street, postalCode, city, phone, email, CVR, companyName, contactFname, contactPhone);
            return updateBusinessDebtor;
        }

        public string DeleteBusinessDebter(int debtorID)
        {
            string deleteBusinessDebter = debtorManager.DeleteBusinessDebtor(debtorID);
            return deleteBusinessDebter;
        }

        public void CreateResource(int resourceID, string modelID, int branchID)
        {
            resourceManager.CreateResource(resourceID, modelID, branchID);
        }

        public void ReadResource()
        {
            resourceManager.ReadResource();
        }

        public void UpdateResource(int resourceID, string modelID, double branchID)
        {
            resourceManager.UpdateResource(resourceID, modelID, branchID);
        }

        public void DeleteResource(int resourceID)
        {
            resourceManager.DeleteResource(resourceID);
        }
    }
}
