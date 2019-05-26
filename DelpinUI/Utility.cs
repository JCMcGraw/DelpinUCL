using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelpinUI
{
    static class Utility
    {

        static public bool CheckForValidCVRNumber(string cvrNumber)
        {
            if (cvrNumber.All(char.IsNumber) && cvrNumber.Length == 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool CheckForValidCPRNumber(string cprNumber)
        {
            if (cprNumber.All(char.IsNumber) && cprNumber.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool CheckForValidPostCode(string cprNumber)
        {
            if (cprNumber.All(char.IsNumber) && cprNumber.Length == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
