using System.Collections.Generic;
using System.Linq;

namespace _2.Softuni_Party
{
    using System;
    public class Program
    {
        public static void Main()
        {

            var vip = new HashSet<string>();
            var regular =new SortedSet<string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "PARTY")
                {

                    break;                    
                }
                if (IsVip(input))
                {
                    vip.Add(input);
                }
                else
                {
                    regular.Add(input);
                }

            }
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                    break;
                if (IsVip(input))
                    vip.Remove(input);
                else
                    regular.Remove(input);
            }
            regular.UnionWith(vip);

            Console.WriteLine(regular.Count);
            foreach (var ch in regular)
            {
                Console.WriteLine(ch);   
            }


        }

        private static bool IsVip(string input)
        {
            var firstSymbol = input.First();
            
           
            if (Char.IsDigit(firstSymbol))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
