using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class DebtorManager
    {
        Debtor debtor = new Debtor(0);

        public string CreateDebtor(int debtorID, string name, string adress, int postalCode, string city, string phone, string email)
        {
            string SQL;

            SQL = "Insert into Debtor(debtorID, name, adress,postalCode,city,phone,email) " +
                                         $"values ({debtor.debtorID},'{debtor.name}','{debtor.adress}','{debtor.postalCode}','{debtor.city}','{debtor.phone}','{debtor.email})";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }

        public string ReadDebtor()
        {
            string SQL;

            SQL = "Select * from Debtor";



            return Convert.ToString(DatabaseManager.ReadFromDatabase(SQL));
        }

        public string UpdateDebtor(int debtorID, string name, string adress, int postalCode, string city, string phone, string email)
        {
            string SQL;

            SQL = $"update Debtor set debtorID={debtor.debtorID},name='{debtor.name}',adress='{debtor.adress}" +
                $",postalCode='{debtor.postalCode},city='{debtor.city},phone='{debtor.phone},email='{debtor.email}";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }

        public string DeleteDebtor(int debtorID)
        {
            string SQL;

            SQL = $"Delete from Debtor where debtorID={debtor.debtorID}";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }
    }
}
