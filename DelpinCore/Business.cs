using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class Business : Debtor
    {
        public int CVR { get; private set; }

        public Business(int debtorID, string name, string adress, int postalCode, string city, string phone, string email, int CVR) :base (debtorID,name,adress,postalCode,city,phone,email)
        {
            this.CVR = CVR;
        }
    }
}
