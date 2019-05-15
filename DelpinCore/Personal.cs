using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelpinCore
{
    class Personal : Debtor
    {
        public int CPR { get; private set; }

        public Personal(int debtorID, string name, string adress, int postalCode, string city, string phone, string email,int CPR) : base(debtorID, name, adress, postalCode, city, phone, email)
        {
            this.CPR = CPR;
        }

    }
}
