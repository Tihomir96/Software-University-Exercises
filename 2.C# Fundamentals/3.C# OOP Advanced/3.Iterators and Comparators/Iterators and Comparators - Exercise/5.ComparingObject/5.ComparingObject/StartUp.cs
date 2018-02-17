using System;
using System.Collections.Generic;

namespace _5.ComparingObject
{
    public class StartUp
    {
        public static void Main()
        {
            var persons = new List<Person>();
            string personInfo = string.Empty;
            while ((personInfo=Console.ReadLine())!="END")
            {
                var tokens = personInfo.Split();
                var person = new Person(tokens[0],int.Parse(tokens[1]),tokens[2]);
                persons.Add(person);
            }
            int position = int.Parse(Console.ReadLine()) - 1;
            var personToCompare = persons[position];
            var equal = 0;
            foreach (var person in persons)
            {
                if (personToCompare.CompareTo(person) == 0)
                {
                    equal++;
                }                
            }
            if (equal > 1)
            {
                Console.WriteLine($"{equal} {persons.Count - equal} {persons.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
