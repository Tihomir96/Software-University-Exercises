namespace _6.Filter_by_phone
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var students =new List<string>();
            while (input!="END")
            {   
                students.Add(input);
                input = Console.ReadLine();
            }
            students.Select(s =>
            {
                var tokens = s.Split(' ');
                var name = tokens[0] + " " + tokens[1];
                string phone = tokens[2];
                return new {name, phone};
            }).Where(x=> x.phone.StartsWith("02") || x.phone.StartsWith("+3592")).ToList().ForEach(x=>Console.WriteLine(x.name));
        }
    }
}
