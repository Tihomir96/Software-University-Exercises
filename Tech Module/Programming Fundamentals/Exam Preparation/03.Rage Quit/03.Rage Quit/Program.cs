using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().ToLower();
            var regex = new Regex(@"(?<letter>\D+)(?<repeat>\d+)");
            var matches = regex.Matches(input);
            var sb = new StringBuilder();
            HashSet <char> set= new HashSet<char>();
            foreach (Match match in matches)
            {
                var letter = match.Groups["letter"].Value;
                var repeat = int.Parse(match.Groups["repeat"].Value);
                var uniqueChar = letter.ToCharArray();
                for (int i = 0; i < letter.Length; i++)
                {
                    set.Add(uniqueChar[i]);
                }
                for (int i = 0; i < repeat; i++)
                {
                    sb.Append(letter.ToUpper());
                }
            }
            Console.WriteLine($"Unique symbols used: {sb.ToString().Distinct().Count()}");
            Console.WriteLine($"{sb}");
        }
    }
}
