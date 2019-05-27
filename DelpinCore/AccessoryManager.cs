using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class AccessoryManager
    {
        public string CreateAccessory(string modelID, string accessoryID)
        {
            string createAccessory = "Insert into Accessory(ModelID, accessoryID) " +
                                   $"values ({modelID},{accessoryID})";

            string isCreateAccessory = DatabaseManager.CreateUpdateDeleteInDatabase(createAccessory);
            if (isCreateAccessory != "Success")
            {
                return isCreateAccessory;
            }

            return $"Accessory {modelID}, {accessoryID} er blevet oprettet";
        }

        public string ReadAccessory(int modelID)
        {
            string readAccessory = $"Select * from Accessory where ModelID = {modelID}";
            
            return Convert.ToString(DatabaseManager.ReadFromDatabase(readAccessory));
        }

        public string DeleteAccessory(int accessoryModelID)
        {
            string deleteAccessory = $"Delete from Accessory where AccessoryModelID={accessoryModelID}";
            
            string isdeleteAccessory = DatabaseManager.CreateUpdateDeleteInDatabase(deleteAccessory);
            if (isdeleteAccessory != "Success")
            {
                return deleteAccessory;
            }

            return $"Accessory {accessoryModelID} er blevet Slettet";
        }
    }
}
