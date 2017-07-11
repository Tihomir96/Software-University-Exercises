using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Add_VAT
{
    class Program
    {
        static void Main()
        {
            var input =Console.ReadLine().Split(new []{' ', ','},StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            foreach (var num in input)
            {
                Console.WriteLine($"{num*1.2:f2}");
            }
        }
    }
}
