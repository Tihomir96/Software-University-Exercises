using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8.Extract_Quotations
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"('|"")(.+?)\1");
            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2].Value);   
            }
        }
    }
}
