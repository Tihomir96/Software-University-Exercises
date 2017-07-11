using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Applied_Arithmetics
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var input = Console.ReadLine();
            while (input != "end")
            {
                if (input == "add")
                {
                    numbers = numbers.Select(x=> x+=1).ToList();
                }
                else if (input == "multiply")
                {
                    numbers = numbers.Select(x => x /= 2).ToList();
                }                
                else if (input == "subtract")
                {
                    numbers = numbers.Select(x => x -= 1).ToList();
                }
                else if (input == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
                input = Console.ReadLine();
            }
        }
    }
}
