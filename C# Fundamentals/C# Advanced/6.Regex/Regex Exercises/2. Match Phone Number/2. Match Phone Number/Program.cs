using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2.Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var regex =new Regex(@"(\+359 2 [0-9]{3} [0-9]{4})|(\+359-2-[0-9]{3}-[0-9]{4})$");
            while (input != "end")
            {
                var match = regex.Match(input);
                if (match.Success)
                {
                    Console.WriteLine(match);
                }
                input = Console.ReadLine();
            }
        }
    }
}
