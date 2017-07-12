namespace Rubiks_Cube
{
 using System;
 using System.Linq;
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(" ".ToArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var row = input[0];
            var col = input[1];
            var rubiks = new int[row][];
            var numbers = 1;
            for (int i = 0; i < rubiks.Length; i++)
            {
                rubiks[i] = new int[col];

                for (int j = 0; j < rubiks[i].Length; j++)
                {
                    rubiks[i][j] = numbers;
                    numbers++;
                }
            }

            var comands = int.Parse(Console.ReadLine());

            for (int i = 0; i < comands; i++)
            {
                var comand = Console.ReadLine().Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var position = int.Parse(comand[0]);
                var direction = comand[1];
                var moves = int.Parse(comand[2]);
                moves %= row;
                for (int j = 0; j < moves; j++)
                {
                    DirectionMove(position, direction, rubiks);                                                                                  
                }
            }

            numbers = 0;
            for (int rowIndex = 0; rowIndex < rubiks.Length; rowIndex++)
            {
                for (int colIndex = 0; colIndex < rubiks[rowIndex].Length; colIndex++)
                {
                    if (rubiks[rowIndex][colIndex] == numbers+1)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        SwapRequired(rubiks,rowIndex,colIndex, numbers);
                    }
                    numbers++;
                }
            }
        }

        private static void SwapRequired(int[][] rubiks, int row, int col, int numbers)
        {
            var row2 = 0;
            var col2 = 0;
            for (int i = 0; i < rubiks.Length; i++)
            {
                for (int j = 0; j < rubiks[i].Length; j++)
                {
                    if (rubiks[row][col] == rubiks[i][j])
                    {
                        row2 = i;
                        col2 = j;
                    }
                    if (numbers + 1 == rubiks[i][j])
                    {
                        var swap = rubiks[i][j];
                        rubiks[i][j] = rubiks[row2][col2];
                        rubiks[row2][col2] = swap;
                        Console.WriteLine($"Swap ({row2}, {col2}) with ({i}, {j})");
                        return;
                    }
                }
            }
        }

        private static void DirectionMove(int position, string direction, int[][] rubiks )
        {
            if (direction == "up")
            {                
                for (int i = 0; i < rubiks.Length-1; i++)
                {
                    var temp = rubiks[i][position];
                    rubiks[i][position] = rubiks[i + 1][position];
                    rubiks[i + 1][position] = temp;                    
                }

            }
            else if (direction == "down")
            {
                for (int i = 0; i < rubiks.Length-1; i++)
                {
                    var temp = rubiks[rubiks.Length - i - 1][position];
                    rubiks[rubiks.Length - i - 1][position] = rubiks[rubiks.Length - i - 2][position];
                    rubiks[rubiks.Length - i - 2][position] = temp;
                }
            }
            else if (direction == "left")
            {
                for (int i = 0; i < rubiks[position].Length-1; i++)
                {
                    var temp = rubiks[position][i];
                    rubiks[position][i] = rubiks[position][i + 1];
                    rubiks[position][i + 1] = temp;
                }
            }
            else if (direction == "right")
            {
                for (int i = 0; i < rubiks[position].Length; i++)
                {
                    var temp = rubiks[position][i];
                    rubiks[position][i] = rubiks[position][rubiks[position].Length-1];
                    rubiks[position][rubiks[position].Length - 1] = temp;
                }
            }
        }
    }
}