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
        //Daniel
        //
        public double GetItemsFromDeliveryTable(int zone,bool ton)
        {
            string itemsFromDeliveryTable = $"select * from Delivery where \"Zone\" = {zone} and \"8ton\" ={Convert.ToInt32(ton)}";

            DataTable dataTable = new DataTable();
            dataTable = DatabaseManager.ReadFromDatabase(itemsFromDeliveryTable);

            string getPrice = dataTable.Rows[0]["Price"].ToString();
            double deliveryPrice = Convert.ToDouble(getPrice);

            return deliveryPrice;
        }
    }
}
