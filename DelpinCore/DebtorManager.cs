﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class DebtorManager
    {
        public string CreatePersonalDebtor(int debtorID, string name, string adress, int postalCode, string city, string phone, string email, int CPR)
        {
            string SQL;

            SQL = "Insert into Debtor(debtorID, name, adress,postalCode,city,phone,email) " +
                  $"values ({debtorID},'{name}','{adress}','{postalCode}','{city}','{phone}','{email})"+
                  "Insert into Personal(debtorID, name, adress,postalCode,city,phone,email,CVR) " +
                  $"values ({debtorID},'{name}','{adress}','{postalCode}','{city}','{phone}','{email}','{CPR})"; 

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }

        //public string ReadPersonalDebtor()
        //{
        //    string SQL;

        //    SQL = "Select * from Debtor";

        //    return Convert.ToString(DatabaseManager.ReadFromDatabase(SQL));
        //}

        public string UpdatePersonalDebtor(int debtorID, string name, string adress, int postalCode, string city, string phone, string email, int CPR)
        {
            string SQL;

            SQL = $"update Debtor set debtorID={debtorID},name='{name}',adress='{adress}" +
                $",postalCode='{postalCode},city='{city},phone='{phone},email='{email},CPR='{CPR}";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }

        public string DeletePersonalDebtor(int debtorID)
        {
            string SQL;

            SQL = $"Delete from Debtor where debtorID={debtorID}";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }
    }
}
