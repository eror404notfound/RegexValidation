using Microsoft.Win32;
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
        public static string password = "^?=.+([A-Z]{1})[A-Z]{1}[A-Za-z].{7,}$";
        public static bool RegexValidate(string inputPassword)
        {
            return Regex.IsMatch(inputPassword, password);

        }
        
    }

    
}
