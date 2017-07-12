using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Use_your_chains___buddy
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();

            var regex = new Regex(@"<p>(.*?)</p>");
            var matches = regex.Matches(input);
            var sb= new StringBuilder();
            foreach (Match match in matches)
            {
                var whiteSpace = @"[^a-z0-9]+";
                var reminder = match.Groups[1].Value;
                var replaced =Regex.Replace(reminder, whiteSpace.ToString(), " ");

                foreach (var character in replaced)
                {
                    if (character >= 'a' && character <= 'm')
                    {
                        sb.Append((char)(character + 13));
                    }
                    else if (character >= 'n' && character <= 'z')
                    {
                        sb.Append((char)(character - 13));
                    }
                    else
                    {
                        sb.Append(character);
                    }
                }
            }
            Console.WriteLine(sb);
        }
    }
}
