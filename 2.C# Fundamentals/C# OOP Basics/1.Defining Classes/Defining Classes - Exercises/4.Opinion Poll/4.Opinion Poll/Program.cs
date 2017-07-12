namespace _4.Opinion_Poll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                var personInfo = Console.ReadLine().Split();
                var name = personInfo[0];
                var age = int.Parse(personInfo[1]);
                var person = new Person(name,age);
                list.Add(person);
            }
            foreach (var person in list.Where(x => x.Age > 30).ToList().OrderBy(x => x.Name))
            {

                Console.WriteLine($"{person.name} - {person.age}");
            }
        }
    }
}
