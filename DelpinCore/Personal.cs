using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class Personal : Debtor //Personal Arv from Debtor
    {
        //Daniel
        public string CPR { get; private set; }

        public string firstName { get; private set; }

        public string lastName { get; private set; }

        //Constructor Who has parameters from Base constructor in Debtor Class, + Personal's own Variabels.
        public Personal(string debtorID, string street, int postalCode, string city, string phone, string email,string firstName,string lastName) : base(debtorID, street, postalCode, city, phone, email)
        {
            this.CPR = debtorID;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
