using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6.Valid_Usernames
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"^[\w-]{3,16}$",RegexOptions.Multiline);
            while (input != "END")
            {
                var match = regex.Match(input);

                if (match.Success)
                {
                    Console.WriteLine("valid");
                }
                else if(!match.Success)
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();
            }
        }
    }
}
