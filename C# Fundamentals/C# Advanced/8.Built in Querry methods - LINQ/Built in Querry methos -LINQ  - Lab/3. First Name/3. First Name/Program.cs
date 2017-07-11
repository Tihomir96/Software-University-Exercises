using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.First_Name
{
    class Program
    {
        static void Main()
        {
            var names = Console.ReadLine().Split().ToList();
            var letters = Console.ReadLine().Split().OrderBy(x=>x);
            var result = string.Empty;
            foreach (var letter in letters)
            {
                result = names.Where(l => l.ToLower().StartsWith(letter.ToLower())).FirstOrDefault();
                if (result != null)
                {
                    Console.WriteLine(result);
                    return;
                }                
            }
            Console.WriteLine("No match");
        }
    }
}
