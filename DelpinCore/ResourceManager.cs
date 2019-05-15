using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class ResourceManager
    {
        private Resource activeResource;

        public void ReadResource(int resourceID)
        {
            //activeResource.AddResource(resourceID);
        }

        public void DeleteResource(int resourceID)
        {
            //activeResource.AddResource(resourceID);
        }

        public void CreateResource(int debtorID)
        {
            //activeResource = new Resource(debtorID);
        }

        public void AddResourceToResource(Resource accesories)
        {
            activeResource.AddResource(accesories);
        }

    }
}
