using System;
using System.Linq;

namespace _2.Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var result =Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            Console.WriteLine($"{result.Sum()}{Environment.NewLine}{result.Count}");
        }
    }
}
