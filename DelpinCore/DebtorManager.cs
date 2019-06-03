using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DelpinCore
{
    class DebtorManager
    {
        //Daniel
        public string ReadDebtor()
        {
            string readAllDebtor= "Select * from Debtor";

            return Convert.ToString(DatabaseManager.ReadFromDatabase(readAllDebtor));
        }

        public string CreatePersonalDebtor(string debtorID, string street, int postalCode, string city, string phone, string email, string CPR, string firstName, string lastName)
        {
            string createDebtor = "Insert into Debtor(DebtorID, Street, PostalCode,City,Phone,Email) " +
                  $"values ('{debtorID}','{street}','{postalCode}','{city}','{phone}','{email}')";

            string createPersonal = "Insert into Personal(CPR, FirstName, LastName) " +
                  $"values ('{CPR}','{firstName}','{lastName}')";
           
            

            string isCreateDebtorSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(createDebtor);
            if (isCreateDebtorSuccess != "Success")
            {
                return isCreateDebtorSuccess;
            }

            string isCreatePersonalSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(createPersonal);
            if (isCreatePersonalSuccess != "Success")
            {
                return isCreatePersonalSuccess;
            }

            return $"Kunden '{debtorID}','{street}','{postalCode}','{city}','{phone}','{email}','{CPR}','{firstName}','{lastName} er blevet Oprettet";
            
        }

        public DataTable ReadPersonalDebtor(string debtorID)
        {
            string readPersonalDebtor = $"Select * from Personal join Debtor on Personal.CPR = Debtor.DebtorID Where DebtorID = '{debtorID}'";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(readPersonalDebtor);

            return dataTable;
        }

        //Froklaring på denne
        public Business ReadAllDebtorsByDebtorID(string debtorID)
        {

            string readPersonalDebtor1 = $"Select * From " +
                                         $"(Select " +
                                         $"    Business.CompanyName As Navn, " +
                                         $"    Business.CVR As KundeID, " +
                                         $"    Debtor.Street As Adresse, " +
                                         $"    Debtor.Postalcode As Postkode, " + 
                                         $"    Debtor.City As [By], " +
                                         $"    Debtor.Phone As Telefon, " +
                                         $"    Debtor.Email As Email " +
                                         $"From " +
                                         $"    Debtor Inner Join " +
                                         $"    Business On Business.CVR = Debtor.DebtorID " +
                                         $"Union " +
                                         $"Select " +
                                         $"    Personal.FirstName + ' ' + Personal.LastName As Navn, " +
                                         $"    Personal.CPR As KundeID, " +
                                         $"    Debtor.Street As Adresse, " +
                                         $"    Debtor.Postalcode As Postkode, " +
                                         $"    Debtor.City As [By], " +
                                         $"    Debtor.Phone As Telefon, " +
                                         $"    Debtor.Email As Email " +
                                         $"From " +
                                         $"    Debtor Inner Join " +
                                         $"    Personal On Personal.CPR = Debtor.DebtorID) As AllDebtors " +
                                         $"Where AllDebtors.KundeID = '{debtorID}' ";
            


            DataTable dataTable = DatabaseManager.ReadFromDatabase(readPersonalDebtor1);

            Business business = new Business(debtorID,(string)dataTable.Rows[0]["Adresse"], (int)dataTable.Rows[0]["PostKode"], (string)dataTable.Rows[0]["By"], (string)dataTable.Rows[0]["Telefon"], (string)dataTable.Rows[0]["Email"], (string)dataTable.Rows[0]["Navn"]);

            return business;
        }


        public string UpdatePersonalDebtor(string debtorID, string street, int postalCode, string city, string phone, string email, string CPR, string firstName, string lastName)
        {
            string updateDebtor = $"update Debtor set Street='{street}'" +
                                  $",PostalCode={postalCode},City='{city}',Phone='{phone}',Email='{email}' where DebtorID='{debtorID}'";

            string updatePersonalDebtor = $"update Personal set FirstName='{firstName}',LastName='{lastName}' where CPR='{CPR}'";

            string isUpdateDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(updateDebtor);
            if (isUpdateDebtor != "Success")
            {
                return isUpdateDebtor;
            }

            string isUpdatePersonalDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(updatePersonalDebtor);
            if (isUpdatePersonalDebtor != "Success")
            {
                return isUpdatePersonalDebtor;
            }

            return $"Kunden {debtorID},'{street},'{postalCode},'{city},'{phone},'{email},'{CPR},'{firstName},'{lastName} er blevet Updateret";
        }

        public string DeletePersonalDebtor(string CPR)
        {
            string deletePersonalDebtor = $"Delete from Personal where CPR='{CPR}'";
            string deleteDebtor = $"Delete from Debtor where DebtorID='{CPR}'";
            
            string isDeletePersonalDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(deletePersonalDebtor);
            if (isDeletePersonalDebtor != "Success")
            {
                return isDeletePersonalDebtor;
            }

            string isDeleteDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(deleteDebtor);
            if (isDeleteDebtor != "Success")
            {
                return isDeleteDebtor;
            }

            return $"Kunden '{CPR}' er blevet slettet";
        }

        public string CreateBusinessDebtor(string debtorID, string street, int postalCode, string city, string phone, string email, string CVR, string companyName)
        {
            string createDebtor = "Insert into Debtor(DebtorID, Street, PostalCode,City,Phone,Email) " +
                                  $"values ('{debtorID}','{street}',{postalCode},'{city}','{phone}','{email}')";

            string createBusiness = "Insert into Business(CVR,CompanyName) " +
                                          $"values ('{CVR}','{companyName}')";

            string isCreateDebtorSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(createDebtor);
            if (isCreateDebtorSuccess != "Success")
            {
                return isCreateDebtorSuccess;
            }

            string isCreateBusinessSuccess = DatabaseManager.CreateUpdateDeleteInDatabase(createBusiness);
            if (isCreateBusinessSuccess != "Success")
            {
                return isCreateBusinessSuccess;
            }

            return $"Kunden '{debtorID}','{street}','{postalCode}','{city}','{phone}','{email},'{CVR}','{companyName}'er blevet Oprettet";
        }

        public DataTable ReadBusinessDebtor(string debtorID)
        {
            string readBusinessDebtor = $"Select * from Business join Debtor on Business.CVR = Debtor.DebtorID Where DebtorID = '{debtorID}'";
            DataTable dataTable = DatabaseManager.ReadFromDatabase(readBusinessDebtor);

            return dataTable;
        }

        public string UpdateBusinessDebtor(string debtorID, string street, int postalCode, string city, string phone, string email, string CVR, string companyName)
        {
            string updateDebtor = $"update Debtor set Street='{street}'" +
                                  $",PostalCode={postalCode},City='{city}',Phone='{phone}',Email='{email}' where DebtorID= '{debtorID}'";

            string updateBusinessDebtor = $"update Business set CompanyName='{companyName}' where CVR='{CVR}'";

            string isUpdateDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(updateDebtor);
            if (isUpdateDebtor != "Success")
            {
                return isUpdateDebtor;
            }

            string isUpdateBusinessDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(updateBusinessDebtor);
            if (isUpdateBusinessDebtor != "Success")
            {
                return isUpdateBusinessDebtor;
            }
            return $"Kunden '{debtorID}','{street}',{postalCode},'{city}','{phone}','{email}','{CVR}','{companyName}'er blevet Opdateret";
        }

        public string DeleteBusinessDebtor(string CVR)
        {
            string deleteBusinessDebtor = $"Delete from Business where CVR='{CVR}'";
            string deleteDebtor = $"Delete from Debtor where DebtorID='{CVR}'";
            

            string isDeleteBusinessDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(deleteBusinessDebtor);
            if (isDeleteBusinessDebtor != "Success")
            {
                return isDeleteBusinessDebtor;
            }

            string isDeleteDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(deleteDebtor);
            if (isDeleteDebtor != "Success")
            {
                return isDeleteDebtor;
            }

            return $"Kunden '{CVR}' er blevet slettet";
        }
    }
}
