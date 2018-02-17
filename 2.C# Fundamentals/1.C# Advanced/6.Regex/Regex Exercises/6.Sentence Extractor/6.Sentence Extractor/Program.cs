using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6.Sentence_Extractor
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordPattern = Console.ReadLine();
            var input = Console.ReadLine();
            var regex = new Regex($@"[a-zA-Z0-9 ]+\b{wordPattern}\b\s*.*?[?!.]");
            var matches = regex.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.ToString());
            }
        } 
    }
}
