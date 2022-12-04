using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexValidation2022
{
    internal class RegexValidationCheck
    {
        public static string LastName = "^[A-Z]{1}[a-z]{2,}$";
        public static bool RegexValidate(string inputLastName)
        {
            return Regex.IsMatch(inputLastName, LastName);
        }
    }
}
