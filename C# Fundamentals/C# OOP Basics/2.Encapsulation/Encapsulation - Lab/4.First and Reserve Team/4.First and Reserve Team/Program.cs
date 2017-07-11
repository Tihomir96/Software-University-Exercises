using System;
using System.Collections.Generic;
public class Program
{
    public static void Main()
    {
        var lines = int.Parse(Console.ReadLine());
        var persons = new List<Person>();
            Team team = new Team("Probiv-11");
        for (int i = 0; i < lines; i++)
        {
            try
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0],
                    cmdArgs[1],
                    int.Parse(cmdArgs[2]),
                    double.Parse(cmdArgs[3]));
                persons.Add(person);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
            
        }
        persons.ForEach(p=>team.AddPlayer(p));
        Console.WriteLine($"First team  have {team.FirstTeam.Count} players");
        Console.WriteLine($"Second team have {team.ReserveTeam.Count} players");
    }
}
