﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class ResourceManager
    {
        Resource resource = new Resource(0);

        public string CreateResource(int resourceID, string modelName, double listPrice)
        {
            string SQL;

            SQL = "Insert into VareInfo(resourceID, modelName, listPrice) " +
                                         $"values ({resource.resourceID},'{resource.modelName}','{resource.listPrice})";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }

        public string ReadResource()
        {
            string SQL;

            SQL = "Select * from Resource";

            return Convert.ToString(DatabaseManager.ReadFromDatabase(SQL));
        }

        public string UpdateResource(int resourceID, string modelName, double listPrice)
        {
            string SQL;

            SQL = $"update Resource set resourceID={resource.resourceID},ModelName='{resource.modelName}',listPrice='{resource.listPrice}";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }

        public string DeleteResource(int resourceID)
        {
            string SQL;

            SQL = $"Delete from Resource where ResourceID={resource.resourceID}";

            return DatabaseManager.CreateUpdateDeleteInDatabase(SQL);
        }
    }
}