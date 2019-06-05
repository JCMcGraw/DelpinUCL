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
            return $"Debitor er blevet Oprettet";
        }

        //Her bliver Debtorer joinet på så vi kan se alle atributter som en Personlig debtor har.
        public DataTable ReadPersonalDebtor(string debtorID)
        {
            string readPersonalDebtor = $"Select * from Personal" +
                                        $" join Debtor on Personal.CPR = Debtor.DebtorID Where DebtorID = '{debtorID}'";

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

        public Personal ReadAllPersonalDebtorsByDebtorID(string debtorID)
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

            Personal personal = new Personal(debtorID, (string)dataTable.Rows[0]["Adresse"], (int)dataTable.Rows[0]["PostKode"], (string)dataTable.Rows[0]["By"], (string)dataTable.Rows[0]["Telefon"], (string)dataTable.Rows[0]["Email"], (string)dataTable.Rows[0]["Navn"]);
            return personal;
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
            return $"Debitor er blevet Updateret";
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
            return $"Debitor er blevet slettet";
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
            return $"Debitor er blevet Oprettet";
        }

        //Her bliver Debtorer joinet på så vi kan se alle atributter som en Buisness debtor har.
        public DataTable ReadBusinessDebtor(string debtorID)
        {
            string readBusinessDebtor = $"Select * from Business "+
                $"join Debtor on Business.CVR = Debtor.DebtorID Where DebtorID = '{debtorID}'";

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
            return $"Debitor er blevet Opdateret";
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
            return $"Debitor er blevet slettet";
        }

        //Viser en business debtor ud fra et specefikt CVR-nummer,PR
        public DataTable DisplaySpeceficBusinessDebtor(string CVR)
        {
            string selectBusiness = $"select CVR, CompanyName as Firmanavn, Street as Gade, PostalCode as Postnummer, City as \"By\", Phone as Telefonnummer, Email as \"E-mail\" from Business" +
                $" inner join Debtor on Debtor.DebtorID = Business.CVR where CVR = '{CVR}'";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectBusiness);

            return dataTable;
        }

        //Viser specefik debtor ud fra et CPR-nummer,PR
        public DataTable DisplaySpeceficPersonalDebtor(string CPR)
        {
            string selectPersonal = $"select CPR, FirstName as Fornavn, LastName as Efternavn, Street as Gade, Postalcode as Postnummer, City as \"By\", phone as Telefonnummer, Email as \"E-mail\" from Personal" +
                $" inner join Debtor on Debtor.DebtorID = Personal.CPR where CPR = '{CPR}'";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectPersonal);

            return dataTable;
        }

        //Viser alle businessdebtore,PR
        public DataTable DisplayAllBusinessDebtor()
        {
            string selectBusiness = "select CVR, CompanyName as Firmanavn, Street as Gade, PostalCode as Postnummmer, City as \"By\", Phone as Telefonnummer, Email as \"E-mail\" from Business " +
                " inner join Debtor on Debtor.DebtorID = Business.CVR";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectBusiness);

            return dataTable;
        }

        //Viser alle Personlige Debtore,PR
        public DataTable DisplayAllPersonalDebtor()
        {
            string selectPersonal = "select CPR, FirstName as Fornavn, LastName as Efternavn, Street as Gade, Postalcode as Postnummer, City as \"By\", phone as Telefonnummer, Email as \"E-mail\" from " +
                "Personal inner join Debtor on Debtor.DebtorID = Personal.CPR";
            
            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectPersonal);

            return dataTable;
        }
    }
}
