using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Count_Substring_Occurences
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().ToLower().Split().ToArray();
            var keySubstring = Console.ReadLine().ToLower();
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains(keySubstring))
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
