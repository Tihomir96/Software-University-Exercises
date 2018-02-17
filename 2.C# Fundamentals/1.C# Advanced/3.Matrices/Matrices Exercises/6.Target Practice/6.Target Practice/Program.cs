using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TargetPractice
{
    class TargetPractice
    {
        public static int charIndex = 0;
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries ).Select(int.Parse).ToArray();
            var rows = input[0];
            var cols = input[1];
            char[][] matrix = new char[rows][];
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = new char[cols];
            }
            var snake= Console.ReadLine().ToCharArray();
            
            if (rows % 2 == 0)
            {
                for (int i = matrix.Length-1; i >= 0; i--)
                {

                    if (i % 2 == 0)
                    {
                        LeftToRight(matrix, snake,i);                        
                    }
                    else
                    {
                        RightToLeft(matrix, snake, i);                        
                    }                                       
                }

            }
            else
            {
                for (int i = matrix.Length-1; i >=0; i--)
                {
                    if (i % 2 == 0)
                    {
                        RightToLeft(matrix,snake,i);
                    }
                    else
                    {
                        LeftToRight(matrix,snake,i);
                    }
                }            
            }

            var shotParams = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int shotRow = shotParams[0];
            int shtoCol = shotParams[1];
            int radius = shotParams[2];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (Math.Abs(i - shotRow) + Math.Abs(j - shtoCol) <= radius)
                    {
                        matrix[i][j] = ' ';
                    }
                }
            }

            for(int r = rows-1; r >=0 ; r--)
            {
                for (int c = 0; c < cols; c++)
                {
                    if (matrix[r][c] == ' ')
                    {
                        for (int rr = r-1; rr >= 0; rr--)
                        {
                            if (matrix[rr][c]!=' ')
                            {
                                matrix[r][c] = matrix[rr][c];
                                matrix[rr][c] = ' ';
                            break;
                        }
                    }
                }
            }
        }

            for (int i = 0; i < matrix.Length; i++)
            {
                if (matrix[i].Where(e => e == ' ').Count() == matrix[i].Length)
                {
                    continue;
                }
                Console.WriteLine(string.Join("", matrix[i]));
            }

            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    Console.WriteLine(string.Join("", matrix[i]));
            //}
        }

        private static void RightToLeft(char[][] matrix, char[] snake, int i)
        {
            for (int j = matrix[i].Length - 1; j >= 0; j--)
            {

                matrix[i][j] = snake[charIndex];
                charIndex++;
                if (charIndex == snake.Length)
                {
                    charIndex = 0;
                }
            }
        }

        private static void LeftToRight(char[][] matrix, char[] snake,int row)
        {
            for (int j = 0; j < matrix[row].Length; j++)
            {

                matrix[row][j] = snake[charIndex];
                charIndex++;
                if (charIndex == snake.Length)
                {
                    charIndex = 0;
                }
            }
        }
    }
}