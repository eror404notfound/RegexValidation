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
        {   //Test mail:"abc.xyz@bl.co.in";
            string inputMail = "abc@bl.co";//test for checkig mandatory parts only
            bool result = RegexValidationCheck.RegexValidate(inputMail);
            Console.WriteLine("\n{0}", result);
            Console.ReadLine();
        }
        
        
    }
}
