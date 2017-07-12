using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Big_Numbers
{
    class Program
    {
        static void Main()
        {
            var firstNum = Console.ReadLine();
            var secondNum = Console.ReadLine();

            Console.WriteLine( BigInteger.Parse(firstNum) + BigInteger.Parse(secondNum) ); 
        }
    }
}
