using System;
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
        //Viser en business debtor ud fra et specefikt CVR-nummer,PR
        public DataTable DisplaySpeceficBusinessDebtor(string CVR)
        {
            string selectBusiness = $"select CVR, CompanyName as Firmanavn, Street as Gade, PostalCode as Postnummer, City as \"By\", Phone as Telefonnummer, Email as \"E-mail\" from Business inner join Debtor on Debtor.DebtorID = Business.CVR where CVR = '{CVR}'";


            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectBusiness);

            return dataTable;
        }

        //Viser specefik debtor ud fra et CPR-nummer,PR
        public DataTable DisplaySpeceficPersonalDebtor(string CPR)
        {
            string selectPersonal = $"select CPR, FirstName as Fornavn, LastName as Efternavn, Street as Gade, Postalcode as Postnummer, City as \"By\", phone as Telefonnummer, Email as \"E-mail\" from Personal inner join Debtor on Debtor.DebtorID = Personal.CPR where CPR = '{CPR}'";
            


            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectPersonal);

            return dataTable;
            
        }

        //Viser alle businessdebtore,PR
        public DataTable DisplayAllBusinessDebtor()
        {
            string selectBusiness = "select CVR, CompanyName as Firmanavn, Street as Gade, PostalCode as Postnummmer, City as \"By\", Phone as Telefonnummer, Email as \"E-mail\" from Business inner join Debtor on Debtor.DebtorID = Business.CVR";


            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectBusiness);

            return dataTable;
            
        }

        //Viser alle Personlige Debtore,PR
        public DataTable DisplayAllPersonalDebtor()
        {
            string selectPersonal = "select CPR, FirstName as Fornavn, LastName as Efternavn, Street as Gade, Postalcode as Postnummer, City as \"By\", phone as Telefonnummer, Email as \"E-mail\" from Personal inner join Debtor on Debtor.DebtorID = Personal.CPR";
;


            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectPersonal);

            return dataTable;
            
        }

        //Viser alle resourcerne, deres modeltype og deres lokation,PR
        public DataTable DisplayAllResources()
        {
            string selectResources = "select ResourcesID as Resourcenummer, Model.ModelID as Modelnummer, Model.ModelName as Modelnavn, Branch.City as Lokation from Resources Join Model on Model.ModelID = Resources.ModelID join Branch on Resources.BranchID = Branch.BranchID";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectResources);

            return dataTable;
        }

        //Viser en specefik resource, dens modeltype og dens lokation, PR
        public DataTable DisplaySpecficResources(int resourceID )
        {
            string selectResources = $"select ResourcesID as Resursenummer, model.modelID as Modelnummer, Model.ModelName as Modelnavn, Branch.City as Lokation from Resources Join Model on Model.ModelID = Resources.ModelID join Branch on Resources.BranchID = Branch.BranchID where ResourcesID='{resourceID}' and model.active='1'";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectResources);

            return dataTable;
        }

        //Viser antal af en bestemt model på de forskellige lokationer, PR
        public DataTable CountModelPerBranch(int modelID)
        {
            string selectResources = $"select Model.ModelName as Modelnavn, Branch.City as Lokation, count(Model.ModelID) as Antal from Model join Resources on Model.ModelID = Resources.ModelID join Branch on Branch.BranchID = Resources.BranchID where Model.ModelID = {modelID} group by Branch.City, Model.ModelName'";

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
        //Sim og PR
        public DataTable DisplayBranch()
        {
            string selectBranch = $"select * from Branch";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectBranch);

            return dataTable;
        }
        public DataTable DisplayModelBySubgroupID(int subgroupID)
        {
            string selectModel =$"select  Model.ModelID as Modelnummer, Model.ModelName as Modelnavn, Model.weightKg as Vægt, SubGroup.Category as Katagori, Price as Pris from Model Join SubGroup on subgroup.subgroupID = Model.subgroupID where Model.SubGroupID = {subgroupID}";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectModel);

            return dataTable;
        }
        public DataTable DisplayModel()
        {
            string ShowModel = $"Select ModelID as Modelnummer, ModelName as Modelnavn, weightKg as Vægt, SubGroupID as Katagori, price as Pris from Model";


            DataTable dataTable = DatabaseManager.ReadFromDatabase(ShowModel);

            return dataTable;
        }
        //Viser liste tilbehør, udfra et modelID, PR
        public DataTable DisplaySpeceficAccessory(int modelID)
        {
            string selectAccessory = $"select  model.ModelName as Tilbehør, SubGroup.Category as Kategori, Model.weightKg as vægt, model.Price from Accessory join model on Accessory.AccessoryID = Model.ModelID  join SubGroup on SubGroup.SubGroupID = Model.SubGroupID  where model.ModelID = {modelID}";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectAccessory);

            return dataTable;
        }
        public DataTable DisplayAccModel(   )
        {
            string DisplayAccModel = $"Select *From Model";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(DisplayAccModel);

            return dataTable;
        }
        public DataTable DisplaySpecificModel(int modelID)
        {
            string selectModel = $"select ModelID, ModelName as Modelnavn, Price as Pris, SubGroup.SubGroupID as Undergruppe, MainGroup.MainGroupID as Hovedgruppe, weightKg as Vægt from Model"
+$" join SubGroup on subgroup.SubGroupID = model.SubGroupID"
 +$" join MainGroup on MainGroup.MainGroupID = subgroup.MainGroup"
  +$" where ModelID = {modelID}";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectModel);

            return dataTable;

        }

        public DataTable DisplayDeliveriesforNextNDays(int branchID, int daysInFuture)
        {
            string deliveriesSQL = $"Select " +
                $"    Lease.LeaseID, " +
                $"    AllDebtors.Navn, " +
                $"    LeaseOrder.StartDate As [Leveringsdato], " +
                $"    Count(LeaseOrder.StartDate) As [Antal resurser] " +
                $"From " +
                $"    Lease Join " +
                $"    LeaseOrder On LeaseOrder.LeaseID = Lease.LeaseID Join " +
                $"    (Select " +
                $"         Business.CompanyName As Navn, " +
                $"         Business.CVR As KundeID, " +
                $"         Debtor.Street As Adresse, " +
                $"         Debtor.Postalcode As Postkode, " +
                $"         Debtor.City As [By], " +
                $"         Debtor.Phone As Telefon, " +
                $"         Debtor.Email As Email " +
                $"     From " +
                $"         Debtor Inner Join " +
                $"         Business On Business.CVR = Debtor.DebtorID " +
                $"     Union " +
                $"     Select " +
                $"         Personal.FirstName + ' ' + Personal.LastName As Navn, " +
                $"         Personal.CPR As KundeID, " +
                $"         Debtor.Street As Adresse, " +
                $"         Debtor.Postalcode As Postkode, " +
                $"         Debtor.City As [By], " +
                $"         Debtor.Phone As Telefon, " +
                $"         Debtor.Email As Email " +
                $"     From " +
                $"         Debtor Inner Join " +
                $"         Personal On Personal.CPR = Debtor.DebtorID) As AllDebtors On AllDebtors.KundeID = Lease.DebtorID " +
                $"Where " +
                $"    LeaseOrder.StartDate Between DateAdd(DAY, -1, GetDate()) And DateAdd(DAY, {daysInFuture}, GetDate()) " +
                $"    and Lease.BranchID = {branchID} " +
                $"Group By Lease.LeaseID, AllDebtors.Navn, LeaseOrder.StartDate " +
                $"Order By LeaseOrder.StartDate";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(deliveriesSQL);

            return dataTable;
        }

    }
}
