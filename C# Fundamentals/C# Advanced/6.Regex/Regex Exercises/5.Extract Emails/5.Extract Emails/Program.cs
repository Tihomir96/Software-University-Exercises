using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');
            var regex = new Regex(@"^[A-Za-z0-9]+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\s*");
            for (int i = 0; i < input.Length; i++)
            {
                var match = regex.Match(input[i]);
                if (match.Success)
                {
                    Console.WriteLine(match.ToString());
                }
            }

        }
    }
}
