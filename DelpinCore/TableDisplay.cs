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
        public DataTable DisplaySpeceficBusinessDebtor(string cvr)
        {
            string selectBusiness = $"select CVR, CompanyName as Firmanavn, Street as Gade, PostalCode as Postnummmer, City as Bynavn, ContactFname as Kontaktperson-fornavn, ContactLname as Kontaktperson-Efternavn, ContactPhone as Kontaktperson-telefonnummer from Business inner join Debtor on Debtor.DebtorID = Business.CVR where CVR = '{cvr}'";


            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectBusiness);

            return dataTable;
            
        }

        //Viser specefik debtor ud fra et CPR-nummer
        public DataTable DisplaySpeceficPersonalDebtor(string cpr)
        {
            string selectPersonal = $"select CPR, FirstName as Fornavn, LastName as Efternavn, Street as Gade, Postalcode as Postnummer, City as Bynavn, phone as Telefonnummer, Email as Email from Personalinner join Debtor on Debtor.DebtorID = Personal.CPR where CPR = '{cpr}'";
            ;


            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectPersonal);

            return dataTable;
            
        }

        //Viser alle businessdebtore
        public DataTable DisplayAllBusinessDebtor()
        {
            string selectBusiness = "select CVR, CompanyName as Firmanavn, Street as Gade, PostalCode as Postnummmer, City as Bynavn, ContactFname as Kontaktperson-fornavn, ContactLname as Kontaktperson-Efternavn, ContactPhone as Kontaktperson-telefonnummer from Business inner join Debtor on Debtor.DebtorID = Business.CVR";


            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectBusiness);

            return dataTable;
            
        }

        //Viser alle Personlige Debtore
        public DataTable DisplayAllPersonalDebtor()
        {
            string selectPersonal = "select CPR, FirstName as Fornavn, LastName as Efternavn, Street as Gade, Postalcode as Postnummer, City as Bynavn, phone as Telefonnummer, Email as Email from Personalinner join Debtor on Debtor.DebtorID = Personal.CPR";
;


            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectPersonal);

            return dataTable;
            
        }

        //Viser alle resourcerne, deres modeltype og deres lokation
        public DataTable DisplayAllResources()
        {
            string selectResources = "select ResourcesID as Resourcenummer, Model.ModelName as Modelnavn, Branch.City as Lokation from ResourcesJoin Model on Model.ModelID = Resources.ModelIDjoin Branch on Resources.BranchID = Branch.BranchID";

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
    }
}