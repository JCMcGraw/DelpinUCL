using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class DebtorManager
    {

        //Personal personal = new Personal();
        ////Debtor busimess = new Business();

        public string CreatePersonalDebtor(int debtorID, string name, string adress, int postalCode, string city, string phone, string email, int CPR)
        {
            string SQL;

            SQL = "Insert into Debtor(debtorID, name, adress,postalCode,city,phone,email,CPR) " +
                  $"values ({debtorID},'{name}','{adress}','{postalCode}','{city}','{phone}','{email}','{CPR})";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }

        //public string ReadPersonalDebtor()
        //{
        //    string SQL;

        //    SQL = "Select * from Debtor";

        //    return Convert.ToString(DatabaseManager.ReadFromDatabase(SQL));
        //}

        //public string UpdatePersonalDebtor(int debtorID, string name, string adress, int postalCode, string city, string phone, string email,int CPR)
        //{
        //    string SQL;

        //    SQL = $"update Debtor set debtorID={personal.debtorID},name='{personal.name}',adress='{personal.adress}" +
        //        $",postalCode='{personal.postalCode},city='{personal.city},phone='{personal.phone},email='{personal.email},CPR='{personal.CPR}";

        //    return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        //}

        //public string DeletePersonalDebtor(int debtorID)
        //{
        //    string SQL;

        //    SQL = $"Delete from Debtor where debtorID={personal.debtorID}";

        //    return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        //}
    }
}
