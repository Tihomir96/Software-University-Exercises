using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.List_of_Predicates
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            
            var dividers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var divisible = new List<int>();
            
            for (int i = 1; i <= n; i++)
            {
                bool undivisible = false;
                foreach (var divider in dividers)
                {
                    Predicate<int> predicate = x => x % divider != 0;
                    if (predicate(i))
                    {
                        undivisible = true;
                    }
                }
                if (!undivisible)
                {
                    divisible.Add(i);
                }
                

            }
            Console.WriteLine(string.Join(" ", divisible));
            
        }
    }
}
