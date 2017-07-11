using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Reverse_and_Execute
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());
            nums.Reverse();
            Console.WriteLine(string.Join(" ",nums.Where(x=> x%n!=0)));
        }
    }
}
