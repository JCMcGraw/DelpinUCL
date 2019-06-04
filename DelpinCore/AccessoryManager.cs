﻿using System;
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
    }
}
