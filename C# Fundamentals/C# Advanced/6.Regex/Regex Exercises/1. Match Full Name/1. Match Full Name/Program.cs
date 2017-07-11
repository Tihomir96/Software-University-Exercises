using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.Match_Full_Name
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"^[A-Z][a-z]+ [A-Z][a-z]+");
            while (input != "end")
            {
                var match = regex.Match(input);
                if (match.Success)
                {
                Console.WriteLine(match);                    
                }
                
                input = Console.ReadLine();
            }
        }
    }
}
