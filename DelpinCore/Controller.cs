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

        //public void CreateDebtor(int debtorID, string name, string adress, int postalCode, string city, string phone, string email,int CPR)
        //{
        //    debtorManager.CreatePersonalDebtor(debtorID,name,adress,postalCode,city,phone,email,CPR);
        //}

        //public void ReadDebtor()
        //{
        //    debtorManager.ReadPersonalDebtor();
        //}

        //public void UpdateDebtor(int debtorID, string name, string adress, int postalCode, string city, string phone, string email,int CPR)
        //{
        //    debtorManager.UpdatePersonalDebtor(debtorID,name,adress,postalCode,city,phone,email,CPR);
        //}

        //public void DeteteDebtor(int debtorID)
        //{
        //    debtorManager.DeletePersonalDebtor(debtorID);
        //}

        public void CreateResource(int resourceID, string modelName, double listPrice)
        {
            resourceManager.CreateResource(resourceID,modelName,listPrice);
        }

        public void ReadResource()
        {
            resourceManager.ReadResource();
        }

        public void UpdateResource(int resourceID, string modelName, double listPrice)
        {
            resourceManager.UpdateResource(resourceID,modelName,listPrice);
        }

        public void DeleteResource(int resourceID)
        {
            resourceManager.DeleteResource(resourceID);
        }

    }
}
