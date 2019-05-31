﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class Model
    {
        public int modelID { get; private set; }

        public string modelName { get; private set; }

        public double price { get; private set; }

        public int subGroupID { get; private set; }

        public double weightKG { get; private set; }

        public bool active { get; private set; }

        public Model(int modelID, string modelName, double price, int subGroupID,double weightKG , bool active = true)
        {
            this.modelID = modelID;
            this.modelName = modelName;
            this.price = price;
            this.subGroupID = subGroupID;
            this.weightKG = weightKG;
            this.active = active;
        }

        public Model(int modelID)
        {
            this.modelID = modelID;
        }
    }
}
