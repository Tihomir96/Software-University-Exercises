using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers
{
    class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            double numAverage = numbers.Average();
            var list = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > numAverage)
                {
                    list.Add(numbers[i]);
                }

            }
            if(list.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                var orderedList = list.OrderByDescending(n=>n).ToList();
                if(orderedList.Count > 5)
                {
                    var removerange = orderedList.Count - 5;
                    orderedList.RemoveRange(5, removerange);
                   
                }
                Console.WriteLine(string.Join(" ",orderedList));
                
            }
        }
    }
}
