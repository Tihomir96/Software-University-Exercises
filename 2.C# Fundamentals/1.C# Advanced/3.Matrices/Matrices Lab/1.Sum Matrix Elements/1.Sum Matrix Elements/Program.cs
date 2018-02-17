using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sum_Matrix_Elements
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();            
            int[][] matrix = new int[input[0]][];
            int sum = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    sum += matrix[i][j];
                }

            }
            Console.WriteLine($"{input[0]}\n{input[1]}\n{sum}");


        }
    }
}
