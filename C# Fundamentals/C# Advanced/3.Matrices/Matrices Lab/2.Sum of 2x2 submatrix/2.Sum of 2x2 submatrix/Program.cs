using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sum_of_2x2_submatrix
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new int[input[0]][];
            var maxRow = int.MinValue;
            var maxCol = int.MinValue;
            var maxSum = int.MinValue;
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine()
                    .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

            }
            for (int row = 0; row < matrix.Length-1; row++)
            {
                for (int col = 0; col < matrix[row].Length-1; col++)
                {
                    var newSquareSum = matrix[row][col] +
                                       matrix[row][col+1] +
                                       matrix[row+1][col] +
                                       matrix[row + 1][col + 1];
                    
                    if (newSquareSum > maxSum)
                    {
                        maxSum = newSquareSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[maxRow][maxCol]} {matrix[maxRow][maxCol+1]}");
            Console.WriteLine($"{matrix[maxRow+1][maxCol]} {matrix[maxRow+1][maxCol+1]}");
            Console.WriteLine(maxSum);


            
        }
    }
}
