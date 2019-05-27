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

        public bool ton { get; set; }

        public Delivery(int zone,bool ton)
        {
            this.zone = zone;
            this.ton = ton;
        }

        //public int km { get; set; }

        //public double deliveryPrice { get; private set; }

        //public int deliveryID { get; private set; }

        //public Delivery(int zone, bool ton, int km, double deliveryPrice)
        //{
        //    this.zone = zone;
        //    this.ton = ton;
        //    this.km = km;
        //    this.deliveryPrice = deliveryPrice;
        //}

        //public Delivery(int deliveryID)
        //{
        //    this.deliveryID = deliveryID;
        //}
    }
}
