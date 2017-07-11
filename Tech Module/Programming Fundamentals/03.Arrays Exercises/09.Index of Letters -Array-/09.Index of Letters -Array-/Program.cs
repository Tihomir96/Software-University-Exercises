using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Index_of_Letters__Array_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            int num = 97;

            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"{input[i]} -> {(int)input[i]-97}");

            }
        }
    }
}
