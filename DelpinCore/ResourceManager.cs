using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DelpinCore
{
    class ResourceManager
    {
        //Daniel
        public string CreateResource(int resourceID, int modelID, int branchID)
        {
            string createResource = "Insert into Resources(ResourcesID, ModelID, BranchID) " +
                                   $"values ('{resourceID}','{modelID}','{branchID}')";

            string isCreateResource = DatabaseManager.CreateUpdateDeleteInDatabase(createResource);
            if (isCreateResource != "Success")
            {
                return isCreateResource;
            }

            return $"Resources {resourceID}','{modelID}','{branchID} er blevet Oprettet";
        }

        public string ReadResource()
        {
            string readResource = "Select * from Resources";
            
            return Convert.ToString(DatabaseManager.ReadFromDatabase(readResource));
        }

        public string UpdateResource(int resourceID, int modelID, int branchID)
        {
            string updateResource = $"update Resources set ResourcesID={resourceID}','ModelID='{modelID}','BrancID='{branchID}";
            
            string isUpdateResource = DatabaseManager.CreateUpdateDeleteInDatabase(updateResource);
            if (isUpdateResource != "Success")
            {
                return isUpdateResource;
            }

            return $"Resources {resourceID}','{modelID}','{branchID} er blevet Opdateret";
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

        public DataTable ReadSpecefikSubCataegori(int SubGroupID)
        {
            string SpecefikSubCataegori = $"Select * from Model where SubGroupID={SubGroupID}";

            DataTable dataTable= DatabaseManager.ReadFromDatabase(SpecefikSubCataegori);

            return dataTable;
        }

        public DataTable ReadSpecefikModelResourcesBranch(int ModelID)
        {
            string ReadSpecefikModelResourcesBranch = $"select * from Model" +
                                                      $" join Resources on Model.ModelID = Resources.ModelID" +
                                                      $" join Branch on Branch.BranchID = Resources.BranchID" +
                                                      $" where model.ModelID = {ModelID}";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(ReadSpecefikModelResourcesBranch);
            return dataTable;
        }
        public DataTable DisplayModelBySubgroupID(int ModelID)
        {
            string DisplayModelBySubgroupID = $"Select *From Model Inner Join Accessory On Accessory.ModelID = Model.ModelID" +
                $" Inner Join Model Model1 On Accessory.AccessoryID = Model1.ModelID Where Accessory.ModelID = {ModelID}";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(DisplayModelBySubgroupID);
            return dataTable;
        }
    }
}
