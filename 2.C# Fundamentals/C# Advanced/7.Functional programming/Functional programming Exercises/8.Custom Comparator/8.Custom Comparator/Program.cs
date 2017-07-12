using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _8.Custom_Comparator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(string.Join(" ",Console.ReadLine().Split().Select(int.Parse).ToList().OrderBy(x => x % 2 == 1 || x % 2 == -1).ThenBy(x => x % 2 == 0).ThenBy(x=>x)));            
        }
    }
}
