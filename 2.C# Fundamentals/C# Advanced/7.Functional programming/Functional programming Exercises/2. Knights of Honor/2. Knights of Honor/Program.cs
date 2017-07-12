using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Knights_of_Honor
{
    class Program
    {
        static void Main()
        {
            Console.ReadLine().Split().Select(x=> $"Sir {x}").ToList().ForEach(n=> Console.WriteLine(n));
        }
    }
}
