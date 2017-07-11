using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _11.Semantic_HTML
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var openningPattern = @"<(div)([^>]+)(?:id|class)\s*=\s*""(.*?)""(.*?)>";
            var closingPattern = @"<\/div>\s*<!--\s*(.*)\s*-->";
            while (line!="END")
            {
                Match openingMatch = Regex.Match(line ,openningPattern);
                Match closingMatch = Regex.Match(line, closingPattern);
                if (openingMatch.Success)
                {
                    line= Regex.Replace(line,openningPattern, @"$3 $2 $4").Trim();
                    line = "<"+ Regex.Replace(line, @"\s+", " ")+ ">";
                }
                if (closingMatch.Success)
                {
                    line = ("</"+closingMatch.Groups[1]).Trim()+">";
                }
                Console.WriteLine(line);
                line = Console.ReadLine();
                
            }
        }
    }
}
