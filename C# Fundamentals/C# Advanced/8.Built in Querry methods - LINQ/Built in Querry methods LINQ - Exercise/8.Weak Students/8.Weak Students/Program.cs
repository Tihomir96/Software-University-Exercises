namespace _8.Weak_Students
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
            students.Select(x =>
            {
                var tokens = x.Split();
                var name = tokens[0] + " " + tokens[1];
                var marks = new List<int>();
                marks.Add(int.Parse(tokens[2]));
                marks.Add(int.Parse(tokens[3]));
                marks.Add(int.Parse(tokens[4]));
                marks.Add(int.Parse(tokens[5]));
                return new {name, marks};
            }).ToList().Where(x=> x.marks.Where(m=>m <=3).ToList().Count >= 2).ToList().ForEach(n=> Console.WriteLine(n.name));
        }
    }
}
