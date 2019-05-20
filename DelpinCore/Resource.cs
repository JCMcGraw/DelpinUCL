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

        public int modelID { get; private set; }

        public int branchID { get; private set; }

        public string modelName { get; private set; }

        public double price { get; private set; }

        public int subGroupID { get; private set; }

        //Constructor
        public Resource(int resourceID,int modelID)
        {
            this.resourceID = resourceID;
            this.modelID = modelID;
        }

        //Constructor
        public Resource(int resourceID, int modelID, int branchID, string modelName, double price, int subGroupID)
        {
            this.resourceID = resourceID;
            this.modelID = modelID;
            this.branchID = branchID;
            this.modelName = modelName;
            this.price = price;
            this.subGroupID = subGroupID;
        }
    }
}
