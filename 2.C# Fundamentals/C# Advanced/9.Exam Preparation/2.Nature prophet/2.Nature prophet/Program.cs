namespace _2.Nature_prophet
{
    using System.Linq;
    using System;

    class Program
    {
        static void Main()
        {
            var rowsCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = rowsCols[0];
            int cols = rowsCols[1];
            var matrix = new int[rows][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[cols];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = 0;
                }
            }
            var commands = Console.ReadLine();
            while (commands!="Bloom Bloom Plow")
            {
                var tokens = commands.Split();
                int bloomingRow = int.Parse(tokens[0]);
                int bloomingCol = int.Parse(tokens[1]);
                matrix[bloomingRow][bloomingCol]--;
                for (int i = 0; i < rows; i++)
                {
                    matrix[i][bloomingCol]++;
                }
                for (int i = 0; i < cols; i++)
                {
                    matrix[bloomingRow][i]++;
                }
                commands = Console.ReadLine();
            }
               for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ",matrix[i]));
            }
        }
    }
}
