using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.Extract_Tags
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            while (input != "END")
            {
                var regex = new Regex(@"<.+?>");
                var matches = regex.Matches(input);
                foreach (var match in matches)
                {
                        Console.WriteLine(match);

                }
                input =Console.ReadLine();

            }
            
        }
    }
}
