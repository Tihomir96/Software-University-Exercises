using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Group_by_Group
{
    class Program
    {
        static void Main()
        {
            var person = new List<Person>();
            var input = Console.ReadLine();
            while (input != "END")
            {
                var tokens = input.Split();
                var student =new Person();
                student.Name=tokens[0] + " " + tokens[1];
                student.Group = int.Parse(tokens[2]);
                person.Add(student);
                input = Console.ReadLine();
            }
            var grouped = person.GroupBy(x => x.Group).OrderBy(n => n.Key);
            foreach (var group in grouped)
            {
                Console.Write(group.Key + " - ");
                var list =new List<string>();
                foreach (var name in group)
                {
                    list.Add(name.Name);
                }
                Console.Write(string.Join(", ",list));
                Console.WriteLine();
            }


        }
    }

}
class Person
{
    public string Name { get; set; }
    public int Group { get; set; }
}
