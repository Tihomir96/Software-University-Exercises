using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4.Replace_a_Tag
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var result = string.Empty;
            while (input != "end")
            {
                var regex = new Regex(@"<a href=(.+?)>(.+?)</a>");
                var matches = regex.Matches(input);
                foreach (Match match in matches)
                {
                    result = $"[URL href={match.Groups[1]}]{match.Groups[2]}[/URL]";
                    input = input.Replace(match.ToString(), result);
                }
                Console.WriteLine(input);                
                input = Console.ReadLine();
            }

        }
    }
}
