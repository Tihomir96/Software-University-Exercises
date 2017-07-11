using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Roli_The_Coder
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string, Event>();
            while (input != "Time for Code")
            {
                var splitedInput = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (isValidInput(splitedInput))
                {

                    var id = splitedInput[0].ToString();
                    var eventName = splitedInput[1].ToString().Trim('#');
                    var participants = new List<string>();
                    for (int i = 2; i < splitedInput.Length; i++)
                    {
                        participants.Add(splitedInput[i]);
                    }
                    if (!dict.ContainsKey(id))
                    {
                        Event @event = new Event();
                        @event.EventName = eventName;
                        @event.EventParticipants.UnionWith(participants);
                        dict.Add(id, @event);
                    }
                    else
                    {
                        Event @event = dict[id];
                        if (@event.EventName == eventName)
                        {
                            @event.EventParticipants.UnionWith(participants);

                        }
                        else
                        {
                            input = Console.ReadLine();
                            continue;
                        }

                    }
                    input = Console.ReadLine();
                }
                else
                {
                    input = Console.ReadLine();
                }


            }
            foreach (var kvp in dict.OrderByDescending(x => x.Value.EventParticipants.Count).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{kvp.Value.EventName} - {kvp.Value.EventParticipants.Count}");
                foreach (var participant in kvp.Value.EventParticipants.OrderBy(x=>x))
                {
                    
                    Console.WriteLine($"{participant}");

                    
                }

            }

        }

        private static bool isValidInput(string[] splitedInput)
        {
            
            if (splitedInput[1].StartsWith("#"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        class Event
        {
            public string EventName { get; set; }
            public HashSet<string> EventParticipants { get; set; } = new HashSet<string>();
        }
    }
}
