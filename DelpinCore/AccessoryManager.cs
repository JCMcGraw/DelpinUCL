using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DelpinCore
{
    class AccessoryManager
    {
        //Daniel
        public string CreateAccessory(int modelID, int accessoryID)
        {
            string createAccessory = $"Insert into Accessory(ModelID, accessoryID) " +
                                     $"values ({modelID},{accessoryID})";

            string isCreateAccessory = DatabaseManager.CreateUpdateDeleteInDatabase(createAccessory);
            if (isCreateAccessory != "Success")
            {
                return isCreateAccessory;
            }
            return $"Tilbehør er blevet oprettet";
        }

        //Denne inner joiner model tabellen med Accessory så vi kan se de fælles Kolonner som er i tabellen.
        public DataTable ReadAccessory(int modelID)
        {
            string readAccessory = "Select Model2.ModelID, Model2.ModelName From Model " +
                $"Inner Join Accessory On Accessory.ModelID = Model.ModelID " +
                $"Inner Join Model Model2 On Accessory.AccessoryID = Model2.ModelID " +
                $"Where Accessory.ModelID = {modelID}";
            
            DataTable dataTable = DatabaseManager.ReadFromDatabase(readAccessory);
            return dataTable;
        }

        public string DeleteAccessory(int accessoryModelID)
        {
            string deleteAccessory = $"Delete from Accessory where AccessoryModelID={accessoryModelID}";
            
            string isdeleteAccessory = DatabaseManager.CreateUpdateDeleteInDatabase(deleteAccessory);
            if (isdeleteAccessory != "Success")
            {
                return deleteAccessory;
            }
            return $"Tilbehør er blevet Fjernet";
        }

        //Denne joiner Model med accessery så vi kan se Modelnavn tilbehør og tihørsnummer og sotere efter modelName
        public DataTable DisplayAccesoryRelations()
        {
            string displayAccessoryRelations = "select model.ModelName as Modelnavn, m.ModelName as Tilbehør, Accessory.AccessoryModelID as Tilhørsnummer from model"
                                              + " join Accessory on Accessory.ModelID = Model.ModelID"
                                              + " join model m on m.ModelID = Accessory.AccessoryID"
                                              + " order by model.ModelName";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(displayAccessoryRelations);
            return dataTable;
        }

        //Denne joiner Model med accessery så vi kan se Modelnavn tilbehør og tihørsnummer og søge efter spscefikt subGroupID og sotere efter modelName.
        public DataTable DisplayAccesoryRelationsBySubGroupID(int subGroupID)
        {
            string displayAccessoryRelations = "select model.ModelName as Modelnavn, m.ModelName as Tilbehør, Accessory.AccessoryModelID as Tilhørsnummer from model"
                                              + " join Accessory on Accessory.ModelID = Model.ModelID"
                                              + " join model m on m.ModelID = Accessory.AccessoryID"
                                              + $" where Model.SubGroupID = {subGroupID}"
                                              + " order by model.ModelName";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(displayAccessoryRelations);
            return dataTable;
        }

    }
}
