using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.Equal_Sum__Array_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            bool found = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int rightSum = 0;
                int leftSum = 0;

                for (int j = 0; j < i; j++)
                {
                    leftSum += numbers[j];
                }
                for (int l = i + 1; l < numbers.Length; l++)
                {
                    rightSum += numbers[l];
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    found = true;
                }
            }
            if (found == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}

