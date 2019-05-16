using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class ResourceManager
    {
        public string CreateResource(int resourceID, string modelID, int branchID)
        {
            string createResource ="Insert into Resources(resourceID, modelID, BranchID) " +
                                   $"values ({resourceID},'{modelID}','{branchID})";

            string isCreateResource = DatabaseManager.CreateUpdateDeleteInDatabase(createResource);
            if (isCreateResource != "Succes")
            {
                return isCreateResource;
            }

            return $"Resources {resourceID},'{modelID},'{branchID} er blevet Oprettet";
        }

        public string ReadResource()
        {
            string readResource = "Select * from Resources";

            return Convert.ToString(DatabaseManager.ReadFromDatabase(readResource));
        }

        public string UpdateResource(int resourceID, string modelID, double branchID)
        {
            string updateResource = $"update Resources set resourcesID={resourceID},ModelID='{modelID}',BrancID='{branchID}";

            string isUpdateResource = DatabaseManager.CreateUpdateDeleteInDatabase(updateResource);
            if (isUpdateResource != "Success")
            {
                return isUpdateResource;
            }

            return $"Resources {resourceID},'{modelID},'{branchID} er blevet Opdateret";
        }

        public string DeleteResource(int resourceID)
        {
            string deleteResource = $"Delete from Resources where ResourcesID={resourceID}";

            string isDeleteResource = DatabaseManager.CreateUpdateDeleteInDatabase(deleteResource);
            if (isDeleteResource != "Success")
            {
                return isDeleteResource;
            }

            return $"Resources {resourceID} er blevet Slettet";
        }
    }
}
