using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Pairs_by_Difference___Array_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            int diff = 0;
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    diff = (numbers[i] - numbers[j]);
                    diff = Math.Abs(diff);
                if (diff == n)
                {
                
                    result++;
                }
                }
            }
            Console.WriteLine(result/2);
        }
    }
}
