using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class ResourceManager
    {
        public string CreateResource(int resourceID, int modelID, int branchID, string modelName, double price, int subGroupID)
        {
            string createResource = "Insert into Resources(ResourceID, ModelID, BranchID) " +
                                   $"values ({resourceID},'{modelID}','{branchID})";

            string createModel = "Insert into Model(ModelID, ModelName, Price, SubGroupID) " +
                                   $"values ({modelID},'{modelName}','{price}','{subGroupID})";

            string isCreateResource = DatabaseManager.CreateUpdateDeleteInDatabase(createResource);
            if (isCreateResource != "Success")
            {
                return isCreateResource;
            }

            string isCreateModel = DatabaseManager.CreateUpdateDeleteInDatabase(createModel);
            if (isCreateModel !="Success")
            {
                return isCreateModel;
            }

            return $"Resources {resourceID},'{modelID},'{branchID},'{modelName},'{price},'{subGroupID} er blevet Oprettet";
        }

        public string ReadResource()
        {
            string readResource = "Select * from Resources";
            string readModel = "Select * from Model";

            return Convert.ToString(DatabaseManager.ReadFromDatabase(readResource+readModel));
        }

        public string UpdateResource(int resourceID, int modelID, int branchID, string modelName, double price, int subGroupID)
        {
            string updateResource = $"update Resources set ResourcesID={resourceID},ModelID='{modelID}',BrancID='{branchID}',ModelName='{modelName}',Price='{price}',SubGroupID='{subGroupID}";
            string updateModel = $"update Model set ModelID={modelID}',ModelName='{modelName}',Price='{price}',SubGroupID='{subGroupID}";

            string isUpdateResource = DatabaseManager.CreateUpdateDeleteInDatabase(updateResource);
            if (isUpdateResource != "Success")
            {
                return isUpdateResource;
            }

            string isUpdateModel = DatabaseManager.CreateUpdateDeleteInDatabase(updateModel);
            if (isUpdateModel != "Success")
            {
                return isUpdateModel;
            }

            return $"Resources {resourceID},'{modelID},'{branchID},'{modelName}','{price}','{subGroupID} er blevet Opdateret";
        }

        public string DeleteResource(int resourceID,int modelID)
        {
            string deleteResource = $"Delete from Resources where ResourcesID={resourceID}";
            string deleteModel = $"Delete from Model where ModelID ={modelID}";

            string isDeleteResource = DatabaseManager.CreateUpdateDeleteInDatabase(deleteResource);
            if (isDeleteResource != "Success")
            {
                return isDeleteResource;
            }

            string isDeleteModel = DatabaseManager.CreateUpdateDeleteInDatabase(deleteModel);
            if (isDeleteModel != "Success")
            {
                return isDeleteModel;
            }

            return $"Resources {resourceID},'{modelID} er blevet Slettet";
        }
    }
}
