using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Squares_in_matrix
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = input[0];
            var cols = input[1];
            var matrix = new string[rows][];
            var counter = 0;


            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i]= new string[cols]; 
                var line = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = line[j];
                }
            }
            for (int row = 0; row < matrix.Length-1; row++)
            {
                for (int col = 0; col < matrix[row].Length-1; col++)
                {
                    if (matrix[row][col].Equals(matrix[row][col + 1]) &&
                        matrix[row][col].Equals(matrix[row][col + 1]) &&
                        matrix[row][col].Equals(matrix[row + 1][col]) &&
                        matrix[row][col].Equals(matrix[row + 1][col + 1]))
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
