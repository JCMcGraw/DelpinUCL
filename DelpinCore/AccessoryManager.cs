using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class AccessoryManager
    {
        public string CreateAccessory(int accessoryModelID, string modelID, string accessoryID)
        {
            string createAccessory = "Insert into Accessory(AccessoryModelID, ModelID, accessoryID) " +
                                   $"values ({accessoryModelID},'{modelID}','{accessoryID}')";

            string isCreateAccessory = DatabaseManager.CreateUpdateDeleteInDatabase(createAccessory);
            if (isCreateAccessory != "Success")
            {
                return isCreateAccessory;
            }

            return $"Accessory {accessoryModelID},'{modelID},'{accessoryID} er blevet Oprettet";
        }

        public string ReadAccessory()
        {
            string readAccessory = "Select * from Accessory";
            
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
