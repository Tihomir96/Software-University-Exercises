using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"\b(?<!\.|\-|_)([\w-.]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+\b";

            foreach (Match m in Regex.Matches(input, pattern))
            {
               
                string str = m.Value.ToString();
                if (!(str.StartsWith("_")
                    || str.StartsWith(".")
                    || str.StartsWith("-")
                    || str.EndsWith("_")
                    || str.EndsWith(".")
                    || str.EndsWith("-")))
                {

                    Console.WriteLine(m.Value);
                }
            }
        }
    }
}
