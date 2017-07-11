using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7.Valid_Time
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"([01][01]:[0-5][0-9]:[0-5][0-9] AM)|([01][0-2]:[0-5][0-9]:[0-5][0-9] PM)");
            while (input!="END")
            {
                var match = regex.Match(input);
                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
                input = Console.ReadLine();
            }
        }
    }
}
