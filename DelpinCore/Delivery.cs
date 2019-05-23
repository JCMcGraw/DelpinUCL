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

        public double ton { get; set; }

        public int km { get; set; }

        public double deliveryPrice { get; private set; }

        public Delivery(int zone ,double ton, int km, double deliveryPrice)
        {
            this.zone = zone;
            this.ton = ton;
            this.km = km;
            this.deliveryPrice = deliveryPrice;
        }
    }
}
