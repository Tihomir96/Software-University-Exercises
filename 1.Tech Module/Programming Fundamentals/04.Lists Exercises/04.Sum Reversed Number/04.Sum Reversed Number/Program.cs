
namespace _04.Sum_Reversed_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                string currentNum = input[i];
                string reversedNum = string.Join("",currentNum.Reverse());
                int reversed = int.Parse(reversedNum);

                sum += reversed;
            }
            Console.WriteLine(sum);

        }
    }
}
