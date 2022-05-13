using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RFP_RegexAss
{
    internal class Pattern
    {
        public static string REGEX_FIRSTNAME = "^[A-Z][a-z]{3,}$";
        public bool validateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, REGEX_FIRSTNAME);
        }
    }
}
