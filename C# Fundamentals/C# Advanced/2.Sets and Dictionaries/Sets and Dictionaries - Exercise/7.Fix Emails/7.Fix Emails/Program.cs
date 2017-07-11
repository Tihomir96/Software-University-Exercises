using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, string>();
            while (input != "stop")
            {
                var email = Console.ReadLine();

                if (!dict.ContainsKey(input))
                {
                    
                    if (!(email.EndsWith("uk") || email.EndsWith("us")))
                    {
                        dict.Add(input, email);
                    }
                    
                }
                
                input = Console.ReadLine();

            }
            foreach (var email in dict)
            {
                Console.WriteLine($"{email.Key} -> {email.Value}");

            }
        }
    }
}
