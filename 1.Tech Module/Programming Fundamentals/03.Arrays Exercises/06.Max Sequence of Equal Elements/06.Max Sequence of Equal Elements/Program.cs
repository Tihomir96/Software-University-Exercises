using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Max_Sequence_of_Equal_Elements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var equalNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int max = 0;                
            int num = 0;
            for (int i = 1; i < equalNum.Length; i++)
            {
                int lastNum = equalNum[i-1];
                int nextNum = equalNum[i];
                if(nextNum == lastNum)
                {
                    counter++;
                    if (max < counter)
                    {
                        max = counter;
                        num = nextNum;
                    }
                }else
                {
                    counter = 1;
                }

            }
            for (int i = 0; i < max; i++)
            {
                Console.Write($"{num} ");
            }
           
        }
    }
}
