﻿using System;
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
            string SQL;

            SQL = "Select * from Debtor";

            return Convert.ToString(DatabaseManager.ReadFromDatabase(SQL));
        }

        public string CreatePersonalDebtor(int debtorID, string street, int postalCode, string city, string phone, string email, int CPR, string firstName, string lastName)
        {
            string SQL;

            SQL = "Insert into Debtor(DebtorID, Street, PostalCode,City,Phone,Email) " +
                  $"values ({debtorID},'{street}','{postalCode}','{city}','{phone}','{email})"+

                  "Insert into Personal(CPR, FirstName, LastName,DebtorID) " +
                  $"values ({CPR},'{firstName}','{lastName}','{debtorID})"; 

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
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

        public string CreateBusinessDebtor(int debtorID, string name, string adress, int postalCode, string city, string phone, string email, int CVR)
        {
            string SQL;

            SQL = "Insert into Debtor(debtorID, name, adress,postalCode,city,phone,email) " +
                  $"values ({debtorID},'{name}','{adress}','{postalCode}','{city}','{phone}','{email})" +

                  "Insert into Business(debtorID, name, adress,postalCode,city,phone,email,CVR) " +
                  $"values ({debtorID},'{name}','{adress}','{postalCode}','{city}','{phone}','{email}','{CVR})";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }

        public string ReadBusinessDebtor()
        {
            string SQL;

            SQL = "Select * from Business";

            return Convert.ToString(DatabaseManager.ReadFromDatabase(SQL));
        }

        public string UpdateBusinessDebtor(int debtorID, string name, string adress, int postalCode, string city, string phone, string email, int CVR)
        {
            string SQL;

            SQL = $"update Debtor set debtorID={debtorID},name='{name}',adress='{adress}" +
                $",postalCode='{postalCode},city='{city},phone='{phone},email='{email}" +

                $"update Business set debtorID={debtorID},name='{name}',adress='{adress}" +
                $",postalCode='{postalCode},city='{city},phone='{phone},email='{email},CPR='{CVR}";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }

        public string DeleteBusinessDebtor(int debtorID)
        {
            string SQL;

            SQL = $"Delete from Debtor where debtorID={debtorID}" +
                  $"Delete from Business where debtorID={debtorID}";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }



    }
}
