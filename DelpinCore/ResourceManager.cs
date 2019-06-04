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
            string createResource = "Insert into Resources(ResourcesID, ModelID, BranchID, active) " +
                                   $"values ('{resourceID}','{modelID}','{branchID}',1)";

            string isCreateResource = DatabaseManager.CreateUpdateDeleteInDatabase(createResource);
            if (isCreateResource != "Success")
            {
                return isCreateResource;
            }
            return $"Resurse er blevet Oprettet";
        }

        public string DeactivateResource(int resourceID)
        {
            string deactivateResource = $"Update Resources set Active = '0' where ResourcesID={resourceID}";

            string isDeactivateResource = DatabaseManager.CreateUpdateDeleteInDatabase(deactivateResource);
            if (isDeactivateResource != "Success")
            {
                return isDeactivateResource;
            }
            return $"Resurse er blevet Slettet";
        }

        //public DataTable ReadSpecefikSubCataegori(int SubGroupID)
        //{
        //    string SpecefikSubCataegori = $"Select * from Model where SubGroupID={SubGroupID}";

        //    DataTable dataTable= DatabaseManager.ReadFromDatabase(SpecefikSubCataegori);
        //    return dataTable;
        //}

        public DataTable ReadSpecefikModelResourcesBranch(int ModelID)
        {
            string ReadSpecefikModelResourcesBranch = $"select * from Model" +
                                                      $" join Resources on Model.ModelID = Resources.ModelID" +
                                                      $" join Branch on Branch.BranchID = Resources.BranchID" +
                                                      $" where model.ModelID = {ModelID}";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(ReadSpecefikModelResourcesBranch);
            return dataTable;
        }
    }
}
