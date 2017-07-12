using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("Before: \na = {0} \n b = {1}", a, b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("After: \na = {0} \nb = {1}", a, b);

        }
    }
}
