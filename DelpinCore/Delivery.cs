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

        public double extraKm8 { get; private set; } = 8;

        public double extraKm10 { get; private set; } = 10;

        public double deliveryPrice { get; private set; }

        public Delivery(int zone ,double ton, int km, int extraKm8,int extraKm10, double deliveryPrice)
        {
            this.zone = zone;
            this.ton = ton;
            this.km = km;
            this.extraKm8 = extraKm8;
            this.extraKm10 = extraKm10;
            this.deliveryPrice = deliveryPrice;
        }
    }
}
