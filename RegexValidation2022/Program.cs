using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexValidation2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFirstName = "Raj";
            bool result = RegexValidationCheck.RegexValidate(inputFirstName);
            Console.WriteLine("\n{0}", result);
            Console.ReadLine();
        }
    }
}
