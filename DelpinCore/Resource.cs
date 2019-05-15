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

        List<Resource> accesories = new List<Resource>();

        public Resource(int resourceID)
        {
            this.resourceID = resourceID;
        }

        public Resource(int resourceID, string modelName, double listPrice)
        {
            this.resourceID = resourceID;
            this.modelName = modelName;
            this.listPrice = listPrice;
        }

        public void AddResource(Resource resource)
        {
            accesories.Add(resource);
        }

        public void AddResourceAtSpecificIndes(Resource resource, int indexToAddAt)
        {
            accesories.Insert(indexToAddAt, resource);
        }

        public void RemoveResource(int indexToRemove)
        {
            accesories.RemoveAt(indexToRemove);
        }

        public List<Resource> GetResource()
        {
            return accesories;
        }
    }
}
