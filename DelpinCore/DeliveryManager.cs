using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DelpinCore
{
    class DeliveryManager
    {
        public double GetItemsFromDeliveryTable(int zone,bool ton)
        {
            string itemsFromDeliveryTable = $"select * from Delivery where \"Zone\" = {zone} and \"8ton\" ={ton}";

            DataTable dataTable = new DataTable();
            dataTable = DatabaseManager.ReadFromDatabase(itemsFromDeliveryTable);

            string getPrice = dataTable.Rows[0]["Price"].ToString();
            double databasePrice = Convert.ToDouble(getPrice);

            return databasePrice;
        }

    }
}
