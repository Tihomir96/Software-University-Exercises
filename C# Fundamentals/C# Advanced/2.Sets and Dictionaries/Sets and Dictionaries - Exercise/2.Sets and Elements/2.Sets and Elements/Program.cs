using System.Collections.Generic;
using System.Linq;

namespace _2.Sets_and_Elements
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var nSet = new HashSet<int>();
            var mSet = new HashSet<int>();

            for (int i = 0; i < int.Parse(input[0]); i++)
            {
                var num = int.Parse(Console.ReadLine());
                nSet.Add(num);
            }
            for (int i = 0; i < int.Parse(input[1]); i++)
            {
                var num = int.Parse(Console.ReadLine());
                mSet.Add(num);
            }
            foreach (var num in nSet)
            {
                foreach (var num2 in mSet)
                {
                    if (num == num2)
                    {
                     Console.Write($"{num} ");
                    }
                    
                }
            }
            
        }
    }
}
