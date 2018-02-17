namespace _8.Bunnies
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var r = size[0];
            var c = size[1];
            char[][] matrix = new char[r][];
            bool playerIsDead = false;
            bool playerWin = false;
            int playerRow = 0;
            int playerCol = 0;
            for (int i = 0; i < r; i++)
            {
                matrix[i]= Console.ReadLine().ToCharArray();                
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j]=='P')
                    {
                        playerRow = i;
                        playerCol = j;
                    }
                }
            }
            var commands = Console.ReadLine().ToCharArray();
            for (int i = 0; i < commands.Length; i++)
            {
                if (commands[i]=='U')
                {
                    if (!IsInMatrix(playerRow - 1, playerCol, matrix))
                    {
                        matrix[playerRow][playerCol] = '.';
                        playerWin = true;
                        SpreadBunnies(matrix);
                        break;
                    }
                    else
                    {
                        if (matrix[playerRow - 1][playerCol] == 'B')
                        {
                            playerIsDead = true;
                            playerRow--;
                            break;
                        }
                        else
                        {
                            matrix[playerRow][playerCol] = '.';
                            matrix[playerRow - 1][playerCol] = 'P';
                            playerRow--;
                        }
                    }
                    playerIsDead = SpreadBunnies(matrix);
                    if (playerIsDead)
                    {
                        break;
                    }
                }
                else if (commands[i]=='D')
                {
                    if (!IsInMatrix(playerRow + 1, playerCol, matrix))
                    {
                        matrix[playerRow][playerCol] = '.';
                        playerWin = true;
                        SpreadBunnies(matrix);
                        break;
                    }
                    else
                    {
                        if (matrix[playerRow + 1][playerCol] == 'B')
                        {
                            playerIsDead = true;
                            playerRow++;
                            break;
                        }
                        else
                        {
                            matrix[playerRow][playerCol] = '.';
                            matrix[playerRow + 1][playerCol] = 'P';
                            playerRow++;
                        }                        
                    }
                    playerIsDead = SpreadBunnies(matrix);
                    if (playerIsDead)
                    {
                        break;
                    }
                }
                else if (commands[i]=='L')
                {
                    if (!IsInMatrix(playerRow, playerCol -1, matrix))
                    {
                        matrix[playerRow][playerCol] = '.';
                        playerWin = true;
                        SpreadBunnies(matrix);
                        break;
                    }
                    else
                    {
                        if (matrix[playerRow][playerCol - 1] == 'B')
                        {
                            playerIsDead = true;
                            playerCol--;
                        }
                        else
                        {
                            matrix[playerRow][playerCol] = '.';
                            matrix[playerRow][playerCol - 1] = 'P';
                            playerCol--;
                        }
                        
                    }
                    playerIsDead = SpreadBunnies(matrix);
                    if (playerIsDead)
                    {
                        break;
                    }
                }
                else if( commands[i]=='R')
                {
                    if (!IsInMatrix(playerRow, playerCol + 1, matrix))
                    {
                        matrix[playerRow][playerCol] = '.';
                        playerWin = true;
                        SpreadBunnies(matrix);
                        break;
                    }
                    else
                    {
                        if (matrix[playerRow][playerCol + 1] == 'B')
                        {
                            playerIsDead = true;
                            playerCol++;
                        }
                        else
                        {
                            matrix[playerRow][playerCol] = '.';
                            matrix[playerRow][playerCol + 1] = 'P';
                            playerCol++;
                        }
                    }
                    playerIsDead = SpreadBunnies(matrix);
                    if (playerIsDead)
                    {
                        break;
                    }
                }
            }
            if (playerIsDead)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    Console.WriteLine(string.Join("", matrix[i]));
                }
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
            else
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    Console.WriteLine(string.Join("", matrix[i]));
                }
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
        }
        private static bool SpreadBunnies(char[][] matrix)
        {
            bool playerIsDead = false;
            char[][] cloningMatrix = new char[matrix.Length][];
            for (int i = 0; i < matrix.Length; i++)
            {
                cloningMatrix[i] = string.Join("", matrix[i]).ToCharArray();
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == 'B')
                    {

                        if (IsInMatrix(row + 1, col, matrix))
                        {
                            if (matrix[row + 1][col] == 'P')
                            {
                                playerIsDead = true;
                                cloningMatrix[row + 1][col] = 'B';
                            }
                            else
                            {
                                cloningMatrix[row + 1][col] = 'B';
                            }
                        }
                        if (IsInMatrix(row - 1, col, matrix))
                        {
                            if (matrix[row - 1][col] == 'P')
                            {
                                playerIsDead = true;
                                cloningMatrix[row - 1][col] = 'B';
                            }
                            else
                            {
                                cloningMatrix[row - 1][col] = 'B';
                            }
                        }
                        if (IsInMatrix(row, col + 1, matrix))
                        {
                            if (matrix[row][col + 1] == 'P')
                            {
                                playerIsDead = true;
                                cloningMatrix[row][col + 1] = 'B';
                            }
                            else
                            {
                                cloningMatrix[row][col + 1] = 'B';
                            }
                        }
                        if (IsInMatrix(row, col - 1, matrix))
                        {
                            if (matrix[row][col - 1] == 'P')
                            {
                                playerIsDead = true;
                                cloningMatrix[row][col - 1] = 'B';
                            }
                            else
                            {
                                cloningMatrix[row][col - 1] = 'B';
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = cloningMatrix[i];
            }
            return playerIsDead;
        }
        private static bool IsInMatrix(int row, int col, char[][] matrix)
        {
            if (row >= 0 && row < matrix.Length && col >= 0 && col < matrix[row].Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
