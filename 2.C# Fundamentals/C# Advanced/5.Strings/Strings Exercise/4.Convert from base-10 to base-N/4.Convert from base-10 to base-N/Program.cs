using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _4.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var baseN = BigInteger.Parse(input[0]);
            var num = BigInteger.Parse(input[1]);
            string rem = "";
            while (num != 0)
            {
                BigInteger remainder = num % baseN;
                num = num / baseN;
                rem = string.Concat(rem, remainder);
            }
            Console.WriteLine(Reverse(rem));
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
