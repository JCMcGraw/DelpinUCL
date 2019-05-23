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

        public string UpdatePersonalDebtor(string debtorID, string street, int postalCode, string city, string phone, string email, string CPR, string firstName, string lastName)
        {
            string updateDebtor = $"update Debtor set DebtorID={debtorID},Street='{street}" +
                                  $",PostalCode='{postalCode},City='{city},Phone='{phone},Email='{email}";

            string updatePersonalDebtor = $"update Personal set CPR={CPR},FirstName='{firstName},LastName='{lastName},DebtorID='{debtorID}";

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

        public string DeletePersonalDebtor(string debtorID)
        {
            string deleteDebtor = $"Delete from Debtor where DebtorID={debtorID}";
            string deletePersonalDebtor=$"Delete from Personal where DebtorID={debtorID}";

            string isDeleteDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(deleteDebtor);
            if (isDeleteDebtor != "Success")
            {
                return isDeleteDebtor;
            }

            string isDeletePersonalDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(deletePersonalDebtor);
            if (isDeletePersonalDebtor != "Success")
            {
                return isDeletePersonalDebtor;
            }

            return $"Kunden {debtorID} er blevet slettet";
        }

        public string CreateBusinessDebtor(string debtorID, string street, int postalCode, string city, string phone, string email, string CVR,string companyName)
        {
            string createDebtor = "Insert into Debtor(DebtorID, Street, PostalCode,City,Phone,Email) " +
                                  $"values ('{debtorID}','{street}','{postalCode}','{city}','{phone}','{email}')";

            string createBusinessDebtor = "Insert into Business(CVR,CompanyName,ContactFname,ContactLname,ContactPhone) " +
                                          $"values ('{CVR}','{companyName}')";

            string isCreateDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(createDebtor);
            if (isCreateDebtor != "success")
            {
                return isCreateDebtor;
            }

            string isCreateBusinessDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(createBusinessDebtor);
            if (isCreateBusinessDebtor != "success")
            {
                return isCreateBusinessDebtor;
            }

            return $"Kunden {debtorID},'{street},'{postalCode},'{city},'{phone},'{email},'{CVR},'{companyName}er blevet Oprettet";
        }

        public DataTable ReadBusinessDebtor(string debtorID)
        {
            string readBusinessDebtor = $"Select * from Business join Debtor on Business.CVR = Debtor.DebtorID Where DebtorID = '{debtorID}'";
            DataTable dataTable = DatabaseManager.ReadFromDatabase(readBusinessDebtor);

            return dataTable;
        }

        public string UpdateBusinessDebtor(string debtorID, string street, int postalCode, string city, string phone, string email, string CVR, string companyName)
        {
            string updateDebtor = $"update Debtor set DebtorID={debtorID},Street='{street}" +
                                  $",PostalCode='{postalCode},City='{city},Phone='{phone},Email='{email}";

            string updateBusinessDebtor = $"update Business set CVR={CVR},CompanyName='{companyName},DebtorID='{debtorID}";

            string isUpdateDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(updateDebtor);
            if (isUpdateDebtor != "Success")
            {
                return isUpdateDebtor;
            }

            string isUpdateBusinessDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(updateBusinessDebtor);
            if (isUpdateBusinessDebtor != "Succes")
            {
                return isUpdateBusinessDebtor;
            }
            return $"Kunden {debtorID},'{street},'{postalCode},'{city},'{phone},'{email},'{CVR},'{companyName}er blevet Opdateret";
        }

        public string DeleteBusinessDebtor(string debtorID)
        {
            string deleteDebtor = $"Delete from Debtor where DebtorID='{debtorID}'";
            string deleteBusinessDebtor = $"Delete from Business where DebtorID='{debtorID}'";

            string isDeleteDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(deleteDebtor);
            if (isDeleteDebtor != "Succes")
            {
                return isDeleteDebtor;
            }

            string isDeleteBusinessDebtor = DatabaseManager.CreateUpdateDeleteInDatabase(deleteBusinessDebtor);
            if (isDeleteBusinessDebtor != "Success")
            {
                return isDeleteBusinessDebtor;
            }

            return $"Kunden {debtorID} er blevet slettet";
        }
    }
}
