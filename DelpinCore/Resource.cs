using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class Resource
    {
        //Daniel
        public int resourceID { get; private set; }

        public int modelID { get; private set; }

        public int branchID { get; private set; }

        public Resource(int resourceID,int modelID)
        {
            this.resourceID = resourceID;
            this.modelID = modelID;
        }

        public Resource(int resourceID, int modelID, int branchID)
        {
            this.resourceID = resourceID;
            this.modelID = modelID;
            this.branchID = branchID;
        }

        public Resource(int resourceID)
        {
            this.resourceID = resourceID;
        }
    }
}
