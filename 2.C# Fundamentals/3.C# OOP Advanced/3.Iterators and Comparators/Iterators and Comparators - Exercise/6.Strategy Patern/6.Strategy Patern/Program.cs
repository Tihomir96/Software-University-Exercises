using System;
using System.Collections.Generic;

namespace _6.Strategy_Patern
{
    public class Program
    {
        public static void Main()
        {
            SortedSet<Person> pplSortedByName =new SortedSet<Person>(new NameComparator());
            SortedSet<Person> pplSortedByAge = new SortedSet<Person>(new AgeComparator());

            int numberOfPeople = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfPeople; i++)
            {
                var tokens = Console.ReadLine().Split();
                var person = new Person(tokens[0],int.Parse(tokens[1]));
                pplSortedByName.Add(person);
                pplSortedByAge.Add(person);
            }
            foreach (var person in pplSortedByName)
            {
                Console.WriteLine(person);
            }
            foreach (var person in pplSortedByAge)
            {
                Console.WriteLine(person);
            }

        }
    }
}
