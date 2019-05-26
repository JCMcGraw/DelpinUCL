using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DelpinCore
{
    class DeliveryManager
    {
        public double GetItemsFromDeliveryTable(int deliveryID)
        {
            string itemsFromDeliveryTable = $"select Zone, 8ton, Price from Delivery where DeliveryID={deliveryID}";

            string reader = Convert.ToString(DatabaseManager.ReadFromDatabase(itemsFromDeliveryTable));

            while (Convert.ToBoolean(DatabaseManager.ReadFromDatabase(itemsFromDeliveryTable)))
            {
                ////jeg henter zone, 8ton og price ind som varibel fra databasen.///////


                //string getZone = reader["Zone"];
                //int databaseZone = Convert.ToInt32(getZone);

                //string getTon = reader ["8ton"];
                //bool databaseTon = Convert.ToBoolean(getTon);

                //string getPrice = reader["Price"];
                //double databasePrice = Convert.ToDouble(getPrice);
            }

            return Convert.ToDouble(itemsFromDeliveryTable);
        }

        public double DeliveryPrice(int zone, bool ton, int km, double deliveryPrice)
        {
            if (ton == false)
            {
                if (zone == 0)
                {
                    return deliveryPrice;
                }
                if (zone == 1)
                {
                    return deliveryPrice;
                }
                if (zone == 2)
                {
                    return deliveryPrice;
                }
                if (zone == 3)
                {
                    return deliveryPrice;
                }
                if (zone == 4)
                {
                    return deliveryPrice;
                }
                if (zone == 5)
                {
                    return deliveryPrice;
                }
                if (zone == 6)
                {
                    return deliveryPrice;
                }
                if (zone == 7)
                {
                    return deliveryPrice;
                }
                if (zone == 8)
                {
                    return deliveryPrice;
                }
                if (zone == 9)
                {
                    return deliveryPrice;
                }
                else
                {
                    deliveryPrice = deliveryPrice + (8 * km);
                    return deliveryPrice;
                }
            }
            if (ton == true)
            {
                if (zone ==0)
                {
                    return deliveryPrice;
                }
                if (zone == 1)
                {
                    return deliveryPrice;
                }
                if (zone == 2)
                {
                    return deliveryPrice;
                }
                if (zone == 3)
                {
                    return deliveryPrice;
                }
                if (zone == 4)
                {
                    return deliveryPrice;
                }
                if (zone == 5)
                {
                    return deliveryPrice;
                }
                if (zone == 6)
                {
                    return deliveryPrice;
                }
                if (zone == 7)
                {
                    return deliveryPrice;
                }
                if (zone == 8)
                {
                    return deliveryPrice;
                }
                else
                {
                    deliveryPrice = deliveryPrice + (10 * km);
                    return deliveryPrice;
                }
            }
            return deliveryPrice;
        }
    }
}
