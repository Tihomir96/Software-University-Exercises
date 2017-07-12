using System;
using System.Linq;

namespace _03.Fold_and_Sum.Array
{
    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = input.Length / 4;

            int[] arr1 = new int[k];
            int[] arr2 = new int[k];
            int[] arr3 = new int[k];
            int[] arr4 = new int[k];

            int[] result = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                arr1[i] = input[i];
                arr2[i] = input[i + k];
                arr3[i] = input[i + 2 * k];
                arr4[i] = input[i + 3 * k];

            }
            
            for (int i = 0; i < k; i++)
            {
                result[i] = arr1[k-i-1] + arr2[i];
                result[i + k] = arr3[i] + arr4[k - i - 1];
            }
            Console.WriteLine(string.Join(" ", result));
        }
        
        public static void krasi()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = input.Length / 4;
            int[] result = new int[k * 2];

            for (int i = 0; i < k*2; i++)
            {
                result[i] = input[i] + input[2*k - i - 1];
                result[i + k*2] = input[i+2*k] + input[4*k - i - 1];
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
