using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Count_Same_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var numbers = input.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
            var dict = new SortedDictionary<double, int>();

            foreach (var num in numbers)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }
                else
                {
                    dict[num]++;
                }
            }

            foreach (var num in dict)
            {
                Console.WriteLine($"{num.Key} - {num.Value} times");
            }
        }
    }
}
