using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexValidation2022
{
    internal class Program
    {
        public static void Main()
        {   //Test Mobile Format:91 6354214526 &:91-4568412365
            string inputMobileNo = "91 6321458793";
            bool result = RegexValidationCheck.RegexValidate(inputMobileNo);
            Console.WriteLine("\n{0}", result);
            Console.ReadLine();
        }
    }
}
        
        
    

