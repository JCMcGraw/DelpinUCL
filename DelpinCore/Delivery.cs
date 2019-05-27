using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class Delivery
    {
        //Daniel
        public int zone { get; set; }

        public bool ton { get; set; }

        public Delivery(int zone,bool ton)
        {
            this.zone = zone;
            this.ton = ton;
        }
    }
}
