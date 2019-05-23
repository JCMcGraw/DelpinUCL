using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class Business : Debtor //Business arv from Debtor
    {
        public string CVR { get; private set; }

        public string companyName { get; private set; }

        //Constructor Who has parameters from Base constructor in Debtor Class, + Business's own Variabels
        public Business(string debtorID, string street, int postalCode, string city, string phone, string email, string CVR,string companyName) :base (debtorID,street,postalCode,city,phone,email)
        {
            this.CVR = CVR;
            this.companyName = companyName;
        }
    }
}
