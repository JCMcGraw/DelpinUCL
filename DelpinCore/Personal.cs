using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class Personal : Debtor //Personal Arv from Debtor
    {
        public int CPR { get; private set; }

        public string firstName { get; private set; }

        public string lastName { get; private set; }

        //Constructor Who has parameters from Base constructor in Debtor Class, + Personal's own Variabels.
        public Personal(int debtorID, string street, int postalCode, string city, string phone, string email,int CPR,string firstName,string lastName) : base(debtorID, street, postalCode, city, phone, email)
        {
            this.CPR = CPR;
            this.firstName = firstName;
            this.lastName = lastName;
        }
    }
}
