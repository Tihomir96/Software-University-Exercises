using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Extract_sentences_by_keyword
{
    class Program
    {
        static void Main()
        {
            var word = Console.ReadLine();
            var sentences = Console.ReadLine().Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = "\\b" + word + "\\b";
            var regex = new Regex(pattern);

            foreach (var sentence in sentences)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence);
                }

            }
        }
    }
}
