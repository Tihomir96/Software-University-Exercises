using System;
using System.Collections.Generic;
using System.Linq;


namespace _08.Most_Frequent_Number__Arrays_
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var mostFreqNum = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = 0;
            int index = 0;
            for (int i = 0; i < mostFreqNum.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < mostFreqNum.Length; j++)
                {
                    if (mostFreqNum[i] == mostFreqNum[j])
                    {
                        count++;
                        if (count > max)
                        {
                            max = count;
                            index = i;
                        }
                        
                    }
                }
            }
            Console.WriteLine(mostFreqNum[index]);
        }
    }
}
