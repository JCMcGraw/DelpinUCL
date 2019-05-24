using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class Delivery
    {
        public int zone { get; set; }

        public double weight { get; set; }

        public int km { get; set; }

        public double deliveryPrice { get; private set; }

        public Delivery(int zone ,double weight, int km, double deliveryPrice)
        {
            this.zone = zone;
            this.weight = weight;
            this.km = km;
            this.deliveryPrice = deliveryPrice;
        }

        public Delivery(int zone, double ton)
        {
            this.zone = zone;
            this.weight = ton;
        }

        public Delivery(double deliveryPrice)
        {
            this.deliveryPrice = deliveryPrice;
        }
    }
}
