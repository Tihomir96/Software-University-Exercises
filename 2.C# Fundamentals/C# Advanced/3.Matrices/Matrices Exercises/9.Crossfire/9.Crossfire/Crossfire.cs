using System;
using System.Collections.Generic;
using System.Linq;

namespace _9.Crossfire
{

    public class Crossfire
    {
        static void Main()
        {
            var dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var rows = dimensions[0];
            var cols = dimensions[1];

            var matrix = FillMatrix(rows, cols);

            var command = Console.ReadLine();

            while (command != "Nuke it from orbit")
            {
                var commandTokens = command.Split(' ').Select(int.Parse).ToArray();
                var rowImpact = commandTokens[0];
                var colImpact = commandTokens[1];
                var radius = commandTokens[2];


                for (int rowIndex = rowImpact - radius; rowIndex < rowImpact + radius; rowIndex++)
                {
                    if (IsInMatrix(rowIndex, colImpact, matrix))
                    {
                        matrix[rowIndex][colImpact] = -1;
                    }
                }
                for (int colIndex = colImpact - radius; colIndex <= colImpact + radius; colIndex++)
                {
                    if (IsInMatrix(rowImpact, colIndex, matrix))
                    {
                        matrix[rowImpact][colIndex] = -1;
                    }
                }

                FilterMatrix(matrix);
                command = Console.ReadLine();
            }
            if (matrix.Count == 0)
            {
                return;
            }
            for (int i = 0; i < matrix.Count; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }

        }

        private static void FilterMatrix(List<List<int>> matrix)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                matrix[i].RemoveAll(x => x == -1);
            }
            matrix.RemoveAll(x => x.Count == 0);
        }

        private static bool IsInMatrix(int row, int col, List<List<int>> matrix)
        {
            if (row >= 0 && row < matrix.Count && col >= 0 && col < matrix[row].Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static List<List<int>> FillMatrix(int rows, int cols)
        {
            int counter = 1;
            var matrix = new List<List<int>>();
            for (int i = 0; i < rows; i++)
            {
                matrix.Add(new List<int>());
                for (int j = 0; j < cols; j++)
                {
                    matrix[i].Add(counter);
                    counter++;
                }
            }
            return matrix;
        }
    }
}
