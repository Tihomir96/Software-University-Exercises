using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.A_miner_task
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string,int>();
            while (input != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!dict.ContainsKey(input))
                {
                    dict.Add(input, quantity);
                }
                else
                {
                    dict[input] += quantity;
                }
                input = Console.ReadLine();

            }
            foreach (var mine in dict)
            {
                Console.WriteLine($"{mine.Key} -> {mine.Value}");
                
            }
        }
    }
}
