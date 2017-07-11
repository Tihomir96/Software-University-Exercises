namespace _7.Excellent_Studen
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var students = new List<string>();
            while (input!="END")
            {
                students.Add(input);
                input = Console.ReadLine();
            }
            students.Where(x=> x.Contains('6')).ToList().Select(x =>
            {
                var tokens = x.Split();
                string name = tokens[0] + " " + tokens[1];
                return new {name};
            }).ToList().ForEach(x=> Console.WriteLine(x.name));
        }
    }
}
