﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DelpinCore
{
    class TableDisplay
        //Author: PR
    {
        //Viser en business debtor ud fra et specefikt CVR-nummer
        public DataTable DisplaySpeceficBusinessDebtor(string CVR)
        {
            string selectBusiness = $"select CVR, CompanyName as Firmanavn, Street as Gade, PostalCode as Postnummer, City as \"By\", Phone as Telefonnummer, Email as \"E-mail\" from Business inner join Debtor on Debtor.DebtorID = Business.CVR where CVR = '{CVR}'";


            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectBusiness);

            return dataTable;
        }

        //Viser specefik debtor ud fra et CPR-nummer
        public DataTable DisplaySpeceficPersonalDebtor(string CPR)
        {
            string selectPersonal = $"select CPR, FirstName as Fornavn, LastName as Efternavn, Street as Gade, Postalcode as Postnummer, City as \"By\", phone as Telefonnummer, Email as \"E-mail\" from Personal inner join Debtor on Debtor.DebtorID = Personal.CPR where CPR = '{CPR}'";
            


            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectPersonal);

            return dataTable;
            
        }

        //Viser alle businessdebtore
        public DataTable DisplayAllBusinessDebtor()
        {
            string selectBusiness = "select CVR, CompanyName as Firmanavn, Street as Gade, PostalCode as Postnummmer, City as \"By\", Phone as Telefonnummer, Email as \"E-mail\" from Business inner join Debtor on Debtor.DebtorID = Business.CVR";


            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectBusiness);

            return dataTable;
            
        }

        //Viser alle Personlige Debtore
        public DataTable DisplayAllPersonalDebtor()
        {
            string selectPersonal = "select CPR, FirstName as Fornavn, LastName as Efternavn, Street as Gade, Postalcode as Postnummer, City as \"By\", phone as Telefonnummer, Email as \"E-mail\" from Personal inner join Debtor on Debtor.DebtorID = Personal.CPR";
;


            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectPersonal);

            return dataTable;
            
        }

        //Viser alle resourcerne, deres modeltype og deres lokation
        public DataTable DisplayAllResources()
        {
            string selectResources = "select ResourcesID as Resourcenummer, Model.ModelName as Modelnavn, Branch.City as Lokation from Resources Join Model on Model.ModelID = Resources.ModelID join Branch on Resources.BranchID = Branch.BranchID";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectResources);

            return dataTable;
        }

        //Viser en specefik resource, dens modeltype og dens lokation
        public DataTable DisplaySpecficResources(int resourceID )
        {
            string selectResources = $"select ResourcesID as Resourcenummer, Model.ModelName as Modelnavn, Branch.City as Lokation from ResourcesJoin Model on Model.ModelID = Resources.ModelIDjoin Branch on Resources.BranchID = Branch.BranchID where ResourceID='{resourceID}'";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectResources);

            return dataTable;
        }

        //Table for maingroups
        public DataTable DisplayMainGroup()
        {
            string selectMainGroup = $"select * from MainGroup";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectMainGroup);

            return dataTable;
        }

        //Table for maingroups
        public DataTable DisplaySubGroup()
        {
            string selectSubGroup = $"select * from SubGroup";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectSubGroup);

            return dataTable;
        }
        //Sim
        public DataTable DisplayBranch()
        {
            string selectBranch = $"select * from Branch";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectBranch);

            return dataTable;
        }
        public DataTable DisplayModelBySubgroupID(int subgroupID)
        {
            string selectBranch = $"select * from Model where SubGroupID = {subgroupID}";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectBranch);

            return dataTable;
        }
        public DataTable DisplayModel()
        {
            string ShowModel = $"Select *From Model";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(ShowModel);

            return dataTable;
        }
        public DataTable DisplayAccessoriesByModelID(int modelID)
        {
            string selectAccessory = $"Select *From Model Inner Join Accessory On Accessory.ModelID = Model.ModelID" +
                $" Inner Join Model Model1 On Accessory.AccessoryID = Model1.ModelID Where" +
                $" Accessory.ModelID = { modelID}";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectAccessory);

            return dataTable;
        }
        public DataTable DisplayAccModel(   )
        {
            string DisplayAccModel = $"Select *From Model";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(DisplayAccModel);

            return dataTable;
        }

    }
}
