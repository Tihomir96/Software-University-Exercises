using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace _12.String_Matrix_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] {'(', ')'});
            var rotation = int.Parse(input[1]);
            rotation %= 360;
            var line = "";
            int maxLength = 0;
            var counter = 0;
            line = Console.ReadLine();
            var queue = new Queue<string>();
            char[] word = new char[] {'a'};
            while (line != "END")
            {
                if (line.Length > maxLength)
                {
                    maxLength = line.Length;
                }
                counter++;
                queue.Enqueue(line);
                line = Console.ReadLine();
            }
            char[][] matrix = new char[counter][];
            for (int i = 0; i < counter; i++)
            {
                matrix[i] = new char[maxLength];
                word = queue.Dequeue().ToCharArray();

                var s = 0;
                foreach (char c in word)
                {
                    matrix[i][s] = c;
                    s++;
                }
                if (word.Length < maxLength)
                {
                    for (int j = word.Length; j < maxLength; j++)
                    {
                        matrix[i][j] = ' ';
                    }
                }
            }                
            if (rotation == 90)
            {
                var newMatrix =Rotate(matrix, counter, maxLength);
                for (int i = 0; i < newMatrix.Length; i++)
                {
                    Console.WriteLine($"{string.Join("",newMatrix[i])}");
                }
            }
            else if (rotation == 180)
            {
                var tempMatrix = new char[counter][];
                for (int i = 0; i < counter; i++)
                {
                    tempMatrix[i]=new char[maxLength];
                    for (int j = maxLength-1; j >= 0; j--)
                    {
                        tempMatrix[i][maxLength - 1 - j] = matrix[counter - 1 - i][j];
                    }
                }
                for (int i = 0; i < tempMatrix.Length; i++)
                {
                    Console.WriteLine(string.Join("",tempMatrix[i]));
                }
            }
            else if (rotation == 270)
            {
                var newMatrix = Rotate(matrix,counter,maxLength);
                var tempMatrix = new char[maxLength][];
                for (int i = 0; i < maxLength; i++)
                {
                    tempMatrix[i] = new char[counter];

                    for (int j = counter - 1; j >= 0; j--)
                    {
                        tempMatrix[i][counter - 1 - j] = newMatrix[maxLength - 1 - i][j];
                    }
                }
                for (int i = 0; i < tempMatrix.Length; i++)
                {
                    Console.WriteLine(string.Join("", tempMatrix[i]));
                }


            }
            else if (rotation == 0)
            {
                for (int i = 0; i < matrix.Length; i++)
                {
                    Console.WriteLine(String.Join("",matrix[i]));
                }
            }

        }
        private static char[][] Rotate(char[][] matrix, int counter, int maxLength)
        {
            char[][] newMatrix = new char[maxLength][];
            for (int i = 0; i < newMatrix.Length; i++)
            {
                newMatrix[i] = new char[counter];
                for (int j = 0; j < newMatrix[i].Length; j++)
                {
                    newMatrix[i][j] = matrix[counter-1-j][i];
                }
            }
            return newMatrix;
        }
       
    }
}
