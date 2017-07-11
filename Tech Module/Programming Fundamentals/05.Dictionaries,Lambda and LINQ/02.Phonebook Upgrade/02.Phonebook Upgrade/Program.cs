namespace _01.Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    public class Program
    {
        public static void Main()
        {
            List<string> lines = new List<string>();
            var line = Console.ReadLine();
            var contacts = new SortedDictionary<string, string>();
            while (line != "END")
            {
                lines.Add(line);
                line = Console.ReadLine();

            }
            foreach (string l in lines)
            {
                var phonebook = l.Split(' ');
                string instruction = phonebook[0];
                if (instruction == "ListAll")
                {

                    foreach (var item in contacts)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }

                }
                else if (instruction == "A")
                {
                    string name = phonebook[1];
                    string value = phonebook[2];
                    contacts[name] = value;
                }
                else if (instruction == "S")
                {
                    if (!contacts.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} -> {contacts[name]}");
                    }
                }
            }
        }
    }
}
