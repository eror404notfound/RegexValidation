﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexValidation2022
{
    internal class RegexValidationCheck
    {
        public static string FirstName = "^[A-Z]{1}[a-z]{2}$";
        public static bool RegexValidate(string inputFirstName)
        {
            return Regex.IsMatch(inputFirstName, FirstName);
        }
    }
}
