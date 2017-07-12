using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Phonebook
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, string>();
            bool tr = true;
            while (tr)
            {
                if (input == "search")
                {
                    tr = false;
                    break;
                }
                var line = input.Split('-');
                var name = line[0];
                var phone = line[1];
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, phone);
                    input = Console.ReadLine();
                }
                else
                {
                    dict[name] = phone;
                    input = Console.ReadLine();
                }
            }
            input = Console.ReadLine();
            while (input!="stop")
            {
                
                if (dict.ContainsKey(input))
                {
                    Console.WriteLine($"{input} -> {dict[input]}");
                    input = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                    input = Console.ReadLine();

                }

            }
        }
    }
}
