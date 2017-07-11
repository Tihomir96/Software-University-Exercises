using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Formatting_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToArray();
            var a = int.Parse(input[0]);
            var b = double.Parse(input[1]);
            var c = double.Parse(input[2]);
            var hex = a.ToString("X");
            
            var binary= Convert.ToString(a, 2);
            if (binary.Length >= 10)
            {
                var substring = binary.Substring(0, 10);
                Console.WriteLine(String.Format("|{0,-10}|{1}|{2,10:f2}|{3,-10:f3}|", hex, binary, b, c));
            }
            else if( binary.Length<10)
            {
                var bin = binary.PadLeft(10, '0');
                Console.WriteLine(string.Format("|{0,-10}|{1}|{2,10:f2}|{3,-10:f3}|", hex, bin, b, c));
            }


        }
    }
}
