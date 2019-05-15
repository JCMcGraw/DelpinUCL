﻿using System;
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

        public void CreateBusinessDebtor()
        {


        }




        public void CreateResource(int resourceID, string modelName, double listPrice)
        {
            resourceManager.CreateResource(resourceID, modelName, listPrice);
        }

        public void ReadResource()
        {
            resourceManager.ReadResource();
        }

        public void UpdateResource(int resourceID, string modelName, double listPrice)
        {
            resourceManager.UpdateResource(resourceID, modelName, listPrice);
        }

        public void DeleteResource(int resourceID)
        {
            resourceManager.DeleteResource(resourceID);
        }

    }
}
