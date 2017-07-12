using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Diagonal_Difference
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int [][] matrix = new int[n][];
            var firstDiagonalSum = 0;
            var secondDiagonalSum = 0;
            

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new []{" "},StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                matrix[i] = input;
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (i == j)
                    {
                        var num = matrix[i][j];
                        firstDiagonalSum += num;
                        var num2 = matrix[i][matrix.Length - j - 1];
                        secondDiagonalSum += num2;
                    }
                }
            }

            Console.WriteLine(Math.Abs(firstDiagonalSum-secondDiagonalSum));
            
        }
    }
}
