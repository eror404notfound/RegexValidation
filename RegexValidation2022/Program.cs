using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace RegexValidation2022
{
    internal class Program
    {
        public static void Main()
        {  //Test password 8 chars
            string inputPassword = "Anki1234@5w6o7r8D4567";
            bool result = RegexValidationCheck.RegexValidate(inputPassword);
            if (result = true)
            {
                Console.WriteLine("\n Valid Regex input entered");
            }
            else
                Console.WriteLine("\n Invalid Regex input entered");
            Console.ReadLine();
                
        }

    }
}
        
        
    

