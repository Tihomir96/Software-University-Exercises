using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3.Series_of_Letters
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"([a-zA-Z])\1*");
            var sb = new StringBuilder();
            var mathes = regex.Matches(input);
            var s = "";
            foreach (Match match in mathes)
            {
                s += match.Value.ToCharArray()[0].ToString();
                //var toBeReplaced = match.ToString().ToCharArray();
                //input.
                //input = input.Replace(match.ToString(),toBeReplaced[0].ToString());
            }
            Console.WriteLine(s);

        }
    }
}
