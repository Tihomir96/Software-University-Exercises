using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Predicate_for_names
{
    class Program
    {
        static void Main()
        {
            var length = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Length <= length)
                {
                    Console.WriteLine(input[i]);
                }
            }

        }
    }
}
