namespace _9.Enrolled_2014_15
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
            while (input != "END")
            {
                students.Add(input);
                input = Console.ReadLine();
            }
            students.Select(s =>
            {
                var tokens = s.Split();
                var year1415 = new List<string>();
                var dict = new Dictionary<List<string>, List<int>>();
                year1415.Add(tokens[0]);
                var marks = new List<int>();
                marks.Add(int.Parse(tokens[1]));
                marks.Add(int.Parse(tokens[2]));
                marks.Add(int.Parse(tokens[3]));
                marks.Add(int.Parse(tokens[4]));

                dict.Add(year1415, marks);

                return new { dict };
            }).ToList().ForEach(d => d.dict.Keys.ToList().ForEach(k => k.Where(y => y.EndsWith("14") || y.EndsWith("15"))
            .ToList().ForEach(c => d.dict.Values.ToList().ForEach(i => Console.WriteLine(string.Join(" ", i))))));

        }
    }
}    