using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class DebtorManager
    {
        public string ReadDebtor()
        {
            string readAllDebtor;

            readAllDebtor = "Select * from Debtor";

            return Convert.ToString(DatabaseManager.ReadFromDatabase(readAllDebtor));
        }

        public string CreatePersonalDebtor(int debtorID, string street, int postalCode, string city, string phone, string email, int CPR, string firstName, string lastName)
        {
            string createDebtor = "Insert into Debtor(DebtorID, Street, PostalCode,City,Phone,Email) " +
                  $"values ({debtorID},'{street}','{postalCode}','{city}','{phone}','{email})";

            string createPersonal = "Insert into Personal(CPR, FirstName, LastName,DebtorID) " +
                  $"values ({CPR},'{firstName}','{lastName}','{debtorID})"; 


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

            return $"Kunden er blevet oprettet {debtorID},'{street},'{postalCode},'{city},'{phone},'{email},'{CPR},'{firstName},'{lastName} er blevet Oprettet";
        }

        public string ReadPersonalDebtor()
        {
            string SQL;

            SQL = "Select * from Personal"; 

            return Convert.ToString(DatabaseManager.ReadFromDatabase(SQL));
        }

        public string UpdatePersonalDebtor(int debtorID, string street, int postalCode, string city, string phone, string email, int CPR, string firstName, string lastName)
        {
            string SQL;

            SQL = $"update Debtor set DebtorID={debtorID},Street='{street}" +
                $",PostalCode='{postalCode},City='{city},Phone='{phone},Email='{email}"+

                $"update Personal set CPR={CPR},FirstName='{firstName},LastName='{lastName},DebtorID='{debtorID}";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }

        public string DeletePersonalDebtor(int debtorID)
        {
            string SQL;

            SQL = $"Delete from Debtor where DebtorID={debtorID}"+
                  $"Delete from Personal where DebtorID={debtorID}";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }

        public string CreateBusinessDebtor(int debtorID, string street, int postalCode, string city, string phone, string email, int CVR, string companyName, string contactFname, string contactPhone)
        {
            string SQL;

            SQL = "Insert into Debtor(DebtorID, Street, PostalCode,City,Phone,Email) " +
                  $"values ({debtorID},'{street}','{postalCode}','{city}','{phone}','{email})" +

                  "Insert into Business(CVR,CompanyName,ContactFname,ContactPhone) " +
                  $"values ({CVR},'{companyName}','{contactFname}','{contactPhone}','{debtorID})";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }

        public string ReadBusinessDebtor()
        {
            string SQL;

            SQL = "Select * from Business";

            return Convert.ToString(DatabaseManager.ReadFromDatabase(SQL));
        }

        public string UpdateBusinessDebtor(int debtorID, string street, int postalCode, string city, string phone, string email, int CVR, string companyName, string contactFname, string contactPhone)
        {
            string SQL;

            SQL = $"update Debtor set DebtorID={debtorID},Street='{street}" +
                $",PostalCode='{postalCode},City='{city},Phone='{phone},Email='{email}" +

                $"update Business set CVR={CVR},CompanyName='{companyName},ContactFname='{contactFname},ContactPhone='{contactPhone},DebtorID='{debtorID}";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }

        public string DeleteBusinessDebtor(int debtorID)
        {
            string SQL;

            SQL = $"Delete from Debtor where DebtorID={debtorID}" +
                  $"Delete from Business where DebtorID={debtorID}";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }
    }
}
