
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        var lines = int.Parse(Console.ReadLine());
        
        var list = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            var personInfo = Console.ReadLine().Split();

            var person = new Person(personInfo[0],int.Parse(personInfo[1]));
            list.Add(person);
        }
      
        foreach (var person in list.OrderBy(x=>x.Name).Where(a=>a.Age>30))
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}

