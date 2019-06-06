using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class Business : Debtor //Business arv from Debtor
    {
        //Daniel
        public string CVR { get; private set; }

        public string companyName { get; private set; }

        //Constructor Som har parameters fra Base Constructor i Debtor Classen, + Business's egne Variabeler
        public Business(string debtorID, string street, int postalCode, string city, string phone, string email, string companyName) :base (debtorID,street,postalCode,city,phone,email)
        {
            this.CVR = debtorID; 
            this.companyName = companyName;
        }
    }
}
