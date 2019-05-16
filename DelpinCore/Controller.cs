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

        public void ReadDebtor()
        {
            debtorManager.ReadDebtor();
        }

        public void CreatePersonalDebtor(int debtorID, string street, int postalCode, string city, string phone, string email, int CPR, string firstName, string lastName)
        {
            debtorManager.CreatePersonalDebtor(debtorID, street, postalCode, city, phone, email, CPR,firstName,lastName);
        }

        public void ReadPersonalDebtor()
        {
            debtorManager.ReadPersonalDebtor();
        }

        public void UpdatePersonalDebtor(int debtorID, string street, int postalCode, string city, string phone, string email, int CPR, string firstName, string lastName)
        {
            debtorManager.UpdatePersonalDebtor(debtorID, street, postalCode, city, phone, email, CPR,firstName,lastName);
        }

        public void DetetePersonalDebtor(int debtorID)
        {
            debtorManager.DeletePersonalDebtor(debtorID);
        }

        public void CreateBusinessDebtor(int debtorID, string street, int postalCode, string city, string phone, string email, int CVR, string companyName, string contactFname, string contactPhone)
        {
            debtorManager.CreateBusinessDebtor(debtorID, street, postalCode, city, phone, email, CVR, companyName, contactFname, contactPhone);
        }

        public void ReadBusinessDebtor()
        {
            debtorManager.ReadBusinessDebtor();
        }

        public void UpdateBusinessDebtor(int debtorID, string street, int postalCode, string city, string phone, string email, int CVR, string companyName, string contactFname, string contactPhone)
        {
            debtorManager.UpdateBusinessDebtor(debtorID, street, postalCode, city, phone, email, CVR, companyName, contactFname, contactPhone);
        }

        public void DeleteBusinessDebter(int debtorID)
        {
            debtorManager.DeleteBusinessDebtor(debtorID);
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
