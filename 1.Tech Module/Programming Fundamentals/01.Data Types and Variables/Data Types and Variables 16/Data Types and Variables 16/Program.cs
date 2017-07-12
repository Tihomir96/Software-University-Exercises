using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Types_and_Variables_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = Math.Max(num1, num2);
            double num4 = Math.Min(num1, num2);
        
            if (num3 - num4 < 0.000001)
            {
                Console.Write("True");

            }
            else
            {
                Console.Write("False");
            }
         

        }
    }
}
