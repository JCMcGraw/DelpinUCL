using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class Accessory
    {
        //Daniel
        public int accessoryModelID { get; private set; }

        public string modelID { get; private set; }

        public string accessoryID { get; private set; }

        public Accessory(int accessoryModelID,string modelID, string accessoryID)
        {
            this.accessoryModelID = accessoryModelID;
            this.modelID = modelID;
            this.accessoryID = accessoryID;
        }

        public Accessory(int accessoryModelID)
        {
            this.accessoryModelID = accessoryModelID;
        }
    }
}
