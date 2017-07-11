using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Lab
{
    class Program
    {
        static void Main()
        {
            var separator = new char[]{ ' ', ',' };
            var bannedWords = Console.ReadLine().Split(separator,StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();
            foreach (var word in bannedWords)
            {
                text = text.Replace(word, new string('*', word.Length));
                
            }
            Console.WriteLine(text);


            
        }
    }
}
