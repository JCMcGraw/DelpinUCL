﻿using System;
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
            
            string createModel = "Insert into Model(ModelName, Price, SubGroupID, weightKG) " +
                                   $"values ('{modelName}',{price},{subGroupID},{weightKG})";

            string isCreateModel = DatabaseManager.CreateUpdateDeleteInDatabase(createModel);
            if (isCreateModel != "Success")
            {
                return isCreateModel;
            }

            return $"Model '{modelName}','{price}','{subGroupID}','{weightKG} er blevet Oprettet";
        }

        public string ReadModel()
        {
            string readModel = "Select * from Model";

            return Convert.ToString(DatabaseManager.ReadFromDatabase(readModel));
        }

        public string UpdateModel(int modelID, string modelName, double price, int subGroupID, double weightKG)
        {
            string updateModel = $"update Model set ModelID={modelID}',ModelName='{modelName}',Price='{price}',SubGroupID='{subGroupID}',{weightKG}";

            string isUpdateModel = DatabaseManager.CreateUpdateDeleteInDatabase(updateModel);
            if (isUpdateModel != "Success")
            {
                return isUpdateModel;
            }

            return $"Model {modelID}','{modelName}','{price}','{subGroupID}','{weightKG} er blevet Opdateret";
        }

        public string DeleteModel(int modelID)
        {
            string deleteModel = $"Delete from Model where ModelID ={modelID}";

            string isDeleteModel = DatabaseManager.CreateUpdateDeleteInDatabase(deleteModel);
            if (isDeleteModel != "Success")
            {
                return isDeleteModel;
            }

            return $"Model {modelID} er blevet Slettet";
        }
    }
}