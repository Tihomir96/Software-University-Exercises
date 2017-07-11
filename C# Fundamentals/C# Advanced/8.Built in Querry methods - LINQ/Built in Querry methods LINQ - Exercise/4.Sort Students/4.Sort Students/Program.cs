using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Sort_Students
{
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
                var names = s.Split();
                var firstName = names[0];
                var lastName = names[1];
                return new {firstName, lastName};
            }).OrderBy(x => x.lastName).ThenByDescending(x => x.firstName).ToList().ForEach(x=> Console.WriteLine(x.firstName + " " + x.lastName));           
        }
    }
}
