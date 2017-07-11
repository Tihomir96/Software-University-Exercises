namespace _10.Predicate_Party
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var commands = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries).ToArray();
            while (commands[0]!="Party!")
            {
                if (commands[0] == "Remove")
                {
                    if (commands[1] == "StartsWith")
                    {
                        input.RemoveAll(x => x.StartsWith(commands[2]));
                    }
                    else if (commands[1] == "EndsWith")
                    {
                        input.RemoveAll(x => x.EndsWith(commands[2]));
                    }
                    else if(commands[1]=="Length")
                    {
                        input.RemoveAll(x => x.Length == int.Parse(commands[2]));
                    }
                }
                else if(commands[0]== "Double")
                {
                    if (commands[1]== "StartsWith")
                    {
                        var personsToAdd = input.Where(x => x.StartsWith(commands[2])).ToList();
                        input.AddRange(personsToAdd);                        
                    }
                    else if (commands[1] == "EndsWith")
                    {
                        var personsToAdd = input.Where(x => x.EndsWith(commands[2])).ToList();
                        input.AddRange(personsToAdd);                        
                    }
                    else if( commands[1]=="Length")
                    {
                        var personsToAdd= input.Where(x => x.Length == int.Parse(commands[2])).ToList();
                        input.AddRange(personsToAdd);                        
                    }
                }
                commands = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);
            }
            if (input.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else if (input.Count >= 1)
            {
                Console.WriteLine(string.Join(", ", input.OrderBy(x => x)) + " are going to the party!");
            }
            
        }
    }
}
