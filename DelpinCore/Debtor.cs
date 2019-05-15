using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class Debtor
    {
        public int debtorID { get; private set; }

        public string name { get; private set; }

        public string adress { get; private set; }

        public int postalCode { get; private set; }

        public string city { get; private set; }

        public string phone { get; private set; }

        public string email { get; private set; }

        public Debtor(int debtorID)
        {
            this.debtorID = debtorID;
        }

        public Debtor(int debtorID, string name, string adress, int postalCode, string city, string phone, string email)
        {
            this.debtorID = debtorID;
            this.name = name;
            this.adress = adress;
            this.postalCode = postalCode;
            this.city = city;
            this.phone = phone;
            this.email = email;
        }

        //se
    }
}
