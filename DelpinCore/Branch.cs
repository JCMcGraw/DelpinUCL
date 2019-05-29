using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    public class Branch
    {
        public int branchID { get; private set; }
        public string street { get; private set; }
        public int postCode { get; private set; }
        public string city { get; private set; }
        public string phone  { get; private set; }
        public string email { get; private set; }

        public Branch(int branchID, string street, int postCode, string city, string phone, string email)
        {
            this.branchID = branchID;
            this.street = street;
            this.postCode = postCode;
            this.city = city;
            this.phone = phone;
            this.email = email;
        }
    }
}
