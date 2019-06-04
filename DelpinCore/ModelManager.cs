using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class ModelManager
    {
        public string CreateModel(string modelName, double price, int subGroupID, double weightKG)
        {
            string createModel = "Insert into Model(ModelName, Price, SubGroupID, weightKG,Active) " +
                                $"values ('{modelName}',{price},{subGroupID},{weightKG},'1')";

            string isCreateModel = DatabaseManager.CreateUpdateDeleteInDatabase(createModel);
            if (isCreateModel != "Success")
            {
                return isCreateModel;
            }
            return $"Model er blevet Oprettet";
        }

        public string ReadModel()
        {
            string readModel = "Select * from Model";

            return Convert.ToString(DatabaseManager.ReadFromDatabase(readModel));
        }

        public string UpdateModel(int modelID, string modelName, double price, int subGroupID, double weightKG)
        {
            string updateModel = $"update Model set ModelName='{modelName}',Price={price}" +
                                 $",SubGroupID='{subGroupID}',WeightKg={weightKG} where ModelID ={modelID}";  
                                
            string isUpdateModel = DatabaseManager.CreateUpdateDeleteInDatabase(updateModel);
            if (isUpdateModel != "Success")
            {
                return isUpdateModel;
            }
            return $"Model er blevet Opdateret";
        }

        public string DeleteModel(int modelID)
        {
            string deleteModel = $"update Model set Active ='0' where ModelID ={modelID}";

            string isDeleteModel = DatabaseManager.CreateUpdateDeleteInDatabase(deleteModel);
            if (isDeleteModel != "Success")
            {
                return isDeleteModel;
            }
            return $"Model er blevet Slettet";
        }
    }
}
