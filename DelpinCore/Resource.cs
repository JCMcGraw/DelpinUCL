using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class Resource
    {
        public int resourceID { get; private set; }

        public string modelName { get; private set; }

        public double listPrice { get; private set; }

        public Resource(int resourceID, string modelName, double listPrice)
        {
            this.resourceID = resourceID;
            this.modelName = modelName;
            this.listPrice = listPrice;
        }
    }
}
