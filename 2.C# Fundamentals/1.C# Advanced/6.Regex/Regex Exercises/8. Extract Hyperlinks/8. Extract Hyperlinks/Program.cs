using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8.Extract_Hyperlinks
{
    class Program
    {
        static void Main()
        {
            var line = Console.ReadLine();
            var sb = new StringBuilder();
            while (line!="END")
            {
                sb.Append(line).Append(' ');
                line = Console.ReadLine();
            }
            var matches = Regex.Matches(sb.ToString(), @"<a\s+[^>]*?href\s*=(.*?)>.*?<\s*\/\s*a\s*>");

            foreach (Match match in matches)
            {
                string currentHref = match.Groups[1].ToString().Trim();
                if (currentHref[0] == '"')
                {                   
                    Console.WriteLine(currentHref.Split(new[] { '"' }, StringSplitOptions.RemoveEmptyEntries).First());
                }
                else if (currentHref[0] == '\'')
                {
                    Console.WriteLine(currentHref.Split(new[] {'\''}, StringSplitOptions.RemoveEmptyEntries).First());
                }
                else
                {
                    Console.WriteLine(Regex.Split(currentHref, @"\s+").First());
                }
            }

        }
    }
}
