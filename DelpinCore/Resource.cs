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

        public bool activeResource { get; private set; }

        public Resource(int resourceID,int modelID,bool activeResource = true)
        {
            this.resourceID = resourceID;
            this.modelID = modelID;
            this.activeResource = activeResource;
        }

        public Resource(int resourceID, int modelID, int branchID,bool activeResource = true)
        {
            this.resourceID = resourceID;
            this.modelID = modelID;
            this.branchID = branchID;
            this.activeResource = activeResource;
        }

        public Resource(int resourceID, bool activeResource = true)
        {
            this.resourceID = resourceID;
        }
    }
}
