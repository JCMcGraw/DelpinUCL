using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    abstract class Debtor 
    {
        //Daniel
        public string debtorID { get; private set; }

        public string street { get; private set; }

        public int postalCode { get; private set; }

        public string city { get; private set; }

        public string phone { get; private set; }

        public string email { get; private set; }

        public Debtor(string debtorID)
        {
            this.debtorID = debtorID;
        }

        public Debtor(string debtorID, string street, int postalCode, string city, string phone, string email)
        {
            this.debtorID = debtorID;
            this.street = street;
            this.postalCode = postalCode;
            this.city = city;
            this.phone = phone;
            this.email = email;
        }
    }
}
