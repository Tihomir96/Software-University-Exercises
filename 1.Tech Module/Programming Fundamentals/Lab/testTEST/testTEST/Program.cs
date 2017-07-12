using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            dict.Add(0.ToString(), 0);
            foreach (var item in dict.OrderBy(x=>x.Value))
            {
                Console.WriteLine(item.Key+"+"+item.Value);

            }

        }
    }
}
