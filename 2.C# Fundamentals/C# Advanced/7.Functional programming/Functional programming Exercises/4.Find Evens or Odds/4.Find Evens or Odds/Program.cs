using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Find_Evens_or_Odds
{
    class Program
    {
        static void Main()
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var list = new List<int>();
            for (int i = nums[0]; i <= nums[1]; i++)
            {
                list.Add(i);
            }
            var oddEven = Console.ReadLine();
            if (oddEven == "odd")
            {
                Console.WriteLine(string.Join(" ", list.Where(x => x % 2 == 1||  x % 2 == -1)));
            }
            else
            {
                Console.WriteLine(string.Join(" ",list.Where(x=>x%2==0)));
            }
        }
    }
}
