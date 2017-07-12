using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Filter_by_Age
{
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string,int>();
            for (int i = 0; i < n; i++)
            {
                var people = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);                
                dict.Add(people[0],int.Parse(people[1]));
            }
            var condition = Console.ReadLine();
            var years = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            Func<int,bool> tester = CreateTester(condition, years);
            Action<KeyValuePair<string, int>> printer = CreatePrinter(format);
            InvokePrinter(dict, tester, printer);
        }

        private static void InvokePrinter(Dictionary<string, int> dict, Func<int, bool> tester, Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in dict)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
            }
        }


        private static Action<KeyValuePair<string, int>> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name age":
                    return p =>Console.WriteLine($"{p.Key} - {p.Value}");
                case "name":
                    return p => Console.WriteLine($"{p.Key}");
                case "age":
                    return p => Console.WriteLine($"{p.Value}");
                default:
                    return null;

            }
        }

        private static Func<int, bool> CreateTester(string condition, int age)
        {
            if (condition == "older")
            {
                return n => n >= age;
            }
            else
            {
                return n => n < age;
            }
        }
    }
}
