using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Max_Sequence_of_Equal_Elemen
{
    class Program
    {
        static void Main()
        {
            var inputNumbers = Console.ReadLine().Split();
            int[] parsedNumbers = new int[inputNumbers.Length];
            var longest = new List<int>();
            var current = new List<int>();

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                parsedNumbers[i] = int.Parse(inputNumbers[i]);
            }

            current.Add(parsedNumbers[0]);

            for (int i = 1; i < parsedNumbers.Length; i++)
            {
                if (parsedNumbers[i] == current[0])
                {
                    current.Add(parsedNumbers[i]);
                }
                else
                {
                    if (current.Count > longest.Count)
                    {
                        longest = new List<int>();

                        for (int j = 0; j < current.Count; j++)
                        {
                            longest.Add(current[j]);

                        }

                    }

                }
                Console.WriteLine(string.Join(" ", longest));

            }
        }
    }
}
