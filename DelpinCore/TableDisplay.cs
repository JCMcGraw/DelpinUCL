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

        public DataTable DisplayAccModel(   )
        {
            string DisplayAccModel = $"Select *From Model";
            DataTable dataTable = DatabaseManager.ReadFromDatabase(DisplayAccModel);
            return dataTable;
        }

        public DataTable DisplayDeliveriesforNextNDays(int branchID, int daysInFuture)
        {
            string deliveriesSQL = $"Select " +
                $"    Lease.LeaseID As Ordrenummer, " +
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
