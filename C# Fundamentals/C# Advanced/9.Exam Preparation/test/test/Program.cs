namespace _4.Nature_s_Prophet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var matrixSize = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rowColDict = new Dictionary<int, int>();
            int[][] matrix = new int[matrixSize[0]][];

            for (int row = 0; row < matrixSize[0]; row++)
            {
                matrix[row] = new int[matrixSize[1]];
            }

            var command = Console.ReadLine();
            while (command != "Bloom Bloom Plow")
            {
                var flowerRow = int.Parse(command.Split()[0]);
                var flowerCol = int.Parse(command.Split()[1]);
                rowColDict[flowerRow] = flowerCol;
                command = Console.ReadLine();
            }
                FillMatrix(matrix, rowColDict);


            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }

        }

        private static void FillMatrix(int[][] matrix, Dictionary<int, int> rowColDict)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (rowColDict.ContainsKey(row) && rowColDict[row] == col)
                    {
                        for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
                        {
                            matrix[rowIndex][col] ++;
                        }
                        for (int colIndex = 0; colIndex < matrix[row].Length; colIndex++)
                        {
                            matrix[row][colIndex] ++ ;
                        }
                        matrix[row][col]--;
                    }
                }
            }
        }
    }
}