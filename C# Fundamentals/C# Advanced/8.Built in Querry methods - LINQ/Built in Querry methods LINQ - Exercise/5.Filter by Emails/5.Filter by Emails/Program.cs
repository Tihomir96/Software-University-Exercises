namespace _5.Filter_by_Emails
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
            students.Select(s =>
                {
                    var tokens = s.Split();
                    var name = tokens[0]+ " "+ tokens[1];
                    var email = tokens[2];
                    return new {name, email};
                }
            ).Where(x=> x.email.EndsWith("@gmail.com")).ToList().ForEach(x=> Console.WriteLine(x.name));
        }
    }
}
