using System;
using System.Collections.Generic;
using System.Linq;
namespace _07.Max_Sequence_of_increasing_Elements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var equalNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int max = 1;                
            int num = 0;
            int index = 0;
            for (int i = 1; i < equalNum.Length; i++)
            {
                int lastNum = equalNum[i-1];
                int nextNum = equalNum[i];
                if(nextNum > lastNum)
                {
                    counter++;
                    if (max < counter)
                    {
                        max = counter;
                        index = i;
                    }
                }else
                {
                    counter = 1;
                }

            }
            for (int i = index - max + 1; i <= index; i++)
            {
                Console.Write($"{equalNum[i]} ");
            }
           


        }
    }
}
