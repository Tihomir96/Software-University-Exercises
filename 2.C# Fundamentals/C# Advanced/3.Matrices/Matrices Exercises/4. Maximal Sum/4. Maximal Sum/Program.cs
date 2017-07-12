using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Maximal_Sum
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = input[0];
            var cols = input[1];
            var matrix = new int[rows][];
            var maxSum = int.MinValue;
            int[][] result = new int[3][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new int[cols];
                var line = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = int.Parse(line[j]);
                }
            }
            for (int row = 0; row < matrix.Length - 2; row++)
            {
                for (int col = 0; col < matrix[row].Length - 2; col++)
                {
                    var newSquareSum = matrix[row][col] +
                                       matrix[row][col + 1] +
                                       matrix[row][col + 2] +
                                       matrix[row + 1][col] +
                                       matrix[row + 1][col + 1] +
                                       matrix[row + 1][col + 2] +
                                       matrix[row + 2][col] +
                                       matrix[row + 2][col + 1] +
                                       matrix[row + 2][col + 2];


                    if (newSquareSum > maxSum)
                    {
                        maxSum = newSquareSum;
                        

                        for (int i = 0; i < result.Length; i++)
                        {
                            result[i]=new int[3];
                            for (int j = 0; j < result[i].Length; j++)
                            {
                            result[i][j] = matrix[row+i][col+j];                                
                            }
                        }
                    }

                }
            }
            Console.WriteLine($"Sum = {maxSum}");
            for (int i = 0; i <result.Length ; i++)
            {
                foreach (var row in result[i])
                {
                    Console.Write(string.Join(" ", row)+ " ");

                }
                Console.WriteLine();                
            }
        }
    }
}


