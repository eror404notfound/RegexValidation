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
        public static string email = "^[0-9a-z]{1,}([.+-_]*)(([0-9a-z]{1,})*)(@)(gmail|bl)(.)(com|co)([.]*)([in]*)$";
        public static bool RegexValidate(string inputMail)
        {
            return Regex.IsMatch(inputMail, email);
        }
    }
}
