using System;


namespace _02.Rotate_and_Sum.Arrays
{
   public class Program
    {
        public static void Main(string[] args)
        {
            string[] inputNumbers = Console.ReadLine().Split(' ');
            int[] parsedNumbers = new int[inputNumbers.Length];

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                parsedNumbers[i] = int.Parse(inputNumbers[i]);
                
            }
            int n = int.Parse(Console.ReadLine());
            int[] sum = new int[parsedNumbers.Length]; 

            for (int i = 0; i < n; i++)
            {
                int lastNum = parsedNumbers[parsedNumbers.Length - 1];
                for (int j = parsedNumbers.Length-1; j > 0; j--)
                {
                    parsedNumbers[j] = parsedNumbers[j - 1];
                    sum[j] = parsedNumbers[j] + sum[j];
                }
                parsedNumbers[0] = lastNum;
                sum[0] = lastNum + sum[0];

                
                
            }
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
