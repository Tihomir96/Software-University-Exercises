using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Group_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
            var zero = input.Where(x => Math.Abs(x) % 3 == 0).ToArray();
            var one = input.Where(x => Math.Abs(x) % 3 == 1).ToArray();
            var two = input.Where(x => Math.Abs(x) % 3 == 2).ToArray();

            var matrix = new int[3][];
            matrix[0] = zero;
            matrix[1] = one;
            matrix[2] = two;

            for (int i = 0; i < matrix.Length; i++)
            {                
               Console.WriteLine($"{string.Join(" ",matrix[i])}");                
            }
        }
    }
}
