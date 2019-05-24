using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class DeliveryManager
    {
        public double DeliveryPrice(int zone, double weight, int km, double deliveryPrice)
        {
            if (weight >= 8000)
            {
                if (zone == 0)
                {
                    deliveryPrice = 0;
                    return deliveryPrice;
                }
                if (zone == 1)
                {
                    deliveryPrice = 330;
                    return deliveryPrice;
                }
                if (zone == 2)
                {
                    deliveryPrice = 390;
                    return deliveryPrice;
                }
                if (zone == 3)
                {
                    deliveryPrice = 490;
                    return deliveryPrice;
                }
                if (zone == 4)
                {
                    deliveryPrice = 590;
                    return deliveryPrice;
                }
                if (zone == 5)
                {
                    deliveryPrice = 690;
                    return deliveryPrice;
                }
                if (zone == 6)
                {
                    deliveryPrice = 780;
                    return deliveryPrice;
                }
                if (zone == 7)
                {
                    deliveryPrice = 910;
                    return deliveryPrice;
                }
                if (zone == 8)
                {
                    deliveryPrice = 1010;
                    return deliveryPrice;
                }
                if (zone == 9)
                {
                    deliveryPrice = 1140;
                    return deliveryPrice;
                }
                else
                {
                    deliveryPrice = 1140 + (8 * km);
                    return deliveryPrice;
                }
            }
            if (weight < 8000)
            {
                if (zone ==0)
                {
                    deliveryPrice = 0;
                    return deliveryPrice;
                }
                if (zone == 1)
                {
                    deliveryPrice = 490;
                    return deliveryPrice;
                }
                if (zone == 2)
                {
                    deliveryPrice = 750;
                    return deliveryPrice;
                }
                if (zone == 3)
                {
                    deliveryPrice = 910;
                    return deliveryPrice;
                }
                if (zone == 4)
                {
                    deliveryPrice = 1040;
                    return deliveryPrice;
                }
                if (zone == 5)
                {
                    deliveryPrice = 1210;
                    return deliveryPrice;
                }
                if (zone == 6)
                {
                    deliveryPrice = 1370;
                    return deliveryPrice;
                }
                if (zone == 7)
                {
                    deliveryPrice = 1560;
                    return deliveryPrice;
                }
                if (zone == 8)
                {
                    deliveryPrice = 1730;
                    return deliveryPrice;
                }
                else
                {
                    deliveryPrice = 1730 + (10 * km);
                    return deliveryPrice;
                }
            }
            return deliveryPrice;
        }
    }
}
