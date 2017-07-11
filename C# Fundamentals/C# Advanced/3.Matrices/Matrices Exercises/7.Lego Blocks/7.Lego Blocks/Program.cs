namespace _7.Lego_Blocks
{
using System;
using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            var rows = int.Parse(Console.ReadLine());
            int[][] firstJagged = new int [rows][];
            int [][] secondJagged = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                firstJagged[i] = input;
            }
            for (int i = 0; i < rows; i++)
            {
                var input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Reverse().ToArray();
                secondJagged[i] = input;
            }
            int sumFirst =firstJagged[0].Length+secondJagged[0].Length;
            int sumOther = 0;
            int j = 1;

            for (int i = 1; i < rows; i++)
            {                
                sumOther = firstJagged[i].Length + secondJagged[i].Length;
                if (sumFirst == sumOther )
                {
                    continue;
                }
                else
                {
                    var counter = 0;
                    for (int k = 0; k < firstJagged.Length; k++)
                    {
                        counter += firstJagged[k].Length + secondJagged[k].Length;
                    }
                    Console.WriteLine($"The total number of cells is: {counter}");
                    return;
                };
            }
            Print(firstJagged, secondJagged);
        }
        private static void Print(int [][]firstJagged,int[][]secondJagged)
        {
            for (int i = 0; i < firstJagged.Length; i++)

            {
                Console.WriteLine("["+string.Join(", ",firstJagged[i])+ ", "+ string.Join(", ",secondJagged[i])+ "]");
            }            
        }
    }
}
