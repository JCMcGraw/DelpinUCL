using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;
using System.IO;


namespace DelpinUI
{
    static class Utility
    {
        public static int BranchID = 1;
        public static DataTable Branches;

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

        static public bool CheckForValidEmail(string email)
        {
            if (Regex.IsMatch(email, @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}\b", RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string WriteToTextFile(string fileName, string content)
        {
            try
            {
                StreamWriter streamWriter = new StreamWriter(fileName);
                streamWriter.Write(content);
                streamWriter.Close();

                return "Success";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static string ReadFromTextFile(string fileName)
        {
            if (File.Exists(fileName) == false)
            {
                return "FileNotFound";
            }
            try
            {
                StreamReader streamReader = new StreamReader(fileName);
                string content = streamReader.ReadToEnd();
                streamReader.Close();
                return content;
            }
            catch (Exception e)
            {
                return "Error: " + e.Message;
            }
        }
    }
}
