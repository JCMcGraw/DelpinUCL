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

        public DataTable ReadSpecefikModelResourcesBranch(int ModelID)
        {
            string ReadSpecefikModelResourcesBranch = $"select * from Model" +
                                                      $" join Resources on Model.ModelID = Resources.ModelID" +
                                                      $" join Branch on Branch.BranchID = Resources.BranchID" +
                                                      $" where model.ModelID = {ModelID}";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(ReadSpecefikModelResourcesBranch);
            return dataTable;
        }

        //Viser alle resourcerne, deres modeltype og deres lokation,PR
        public DataTable DisplayAllResources()
        {
            string selectResources = "select ResourcesID as Resourcenummer, Model.ModelID as Modelnummer, Model.ModelName as Modelnavn, Branch.City as Lokation, Branch.BranchID as Afdelingsnummer from Resources" +
                " Join Model on Model.ModelID = Resources.ModelID join Branch on Resources.BranchID = Branch.BranchID where model.active='1' and resources.Active = '1'";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectResources);

            return dataTable;
        }

        //Viser en specefik resource, dens modeltype og dens lokation, PR
        public DataTable DisplaySpecficResources(int resourceID)
        {
            string selectResources = $"select ResourcesID as Resursenummer, model.modelID as Modelnummer, Model.ModelName as Modelnavn, Branch.City as Lokation, Branch.BranchID as Afdelingsnummer from Resources" +
                $" Join Model on Model.ModelID = Resources.ModelID join Branch on Resources.BranchID = Branch.BranchID where ResourcesID='{resourceID}' and model.active='1' and resources.Active = '1'";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectResources);

            return dataTable;
        }
    }
}
