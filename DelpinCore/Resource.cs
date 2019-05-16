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

        public string modelID { get; private set; }

        public double branchID { get; private set; }

        //Constructor
        public Resource(int resourceID)
        {
            this.resourceID = resourceID;
        }

        //Constructor
        public Resource(int resourceID, string modelID, int branchID)
        {
            this.resourceID = resourceID;
            this.modelID = modelID;
            this.branchID = branchID;
        }
    }
}
