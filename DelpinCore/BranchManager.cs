using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DelpinCore
{
    class BranchManager
    {
        public DataTable ReadAllBranches()
        {
            string readAllBranchesSQL = "select * from Branch";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(readAllBranchesSQL);
            return dataTable;
        }

        public Branch ReadBranchByBranchID(int branchID)
        {
            string readBranchByBranchIDSQL = $"select * from branch where BranchID = {branchID}";

            DataTable dataTable = DatabaseManager.ReadFromDatabase(readBranchByBranchIDSQL);

            string street = (string)dataTable.Rows[0]["Street"];
            int postCode = (int)dataTable.Rows[0]["Postalcode"];
            string city = (string)dataTable.Rows[0]["City"];
            string phone = (string)dataTable.Rows[0]["Phone"];
            string email = (string)dataTable.Rows[0]["Email"];

            Branch branch = new Branch(branchID, street, postCode, city, phone, email);

            return branch;
        }

        //Sim og PR
        public DataTable DisplayBranch()
        {
            string selectBranch = $"select * from Branch";
            DataTable dataTable = DatabaseManager.ReadFromDatabase(selectBranch);
            return dataTable;
        }
    }
}
