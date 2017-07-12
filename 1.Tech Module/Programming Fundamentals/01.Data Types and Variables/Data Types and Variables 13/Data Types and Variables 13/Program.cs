using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables_13
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine();
            int n;

            bool b = int.TryParse(a, out n);
            if (b)
            {
                Console.WriteLine("digit");
            }


            else if (a == "a" || a == "e" || a == "i" || a == "o" || a == "u" || a == "y")
            {
                Console.WriteLine("vowel");

            }
            else    
            {
                Console.WriteLine("other");
            }


        }
    }
}

