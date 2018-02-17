using System;
using System.Collections.Generic;
using System.Linq;
using _8.Military_Elite.Entities;
using _8.Military_Elite.Interfaces;

namespace _8.Military_Elite
{
    public class Startup
    {
        private static IList<ISoldier> army;
        public static void Main()
        {
            army=new List<ISoldier>();

            string input = string.Empty;
            while ((input=Console.ReadLine())!="End")
            {
                var inputTokens = input.Split();
                switch (inputTokens[0])
                {
                    case "Private":
                        army.Add(new Private(inputTokens[1], inputTokens[2], inputTokens[3], double.Parse(inputTokens[4])));
                        break;
                    case "Spy":
                        army.Add(new Spy(inputTokens[1], inputTokens[2], inputTokens[3], int.Parse(inputTokens[4])));
                        break;
                    case "LeutenantGeneral":
                        var privates = ExtractPrivates(inputTokens.Skip(5).ToList());
                        army.Add(new LeutenantGeneral(inputTokens[1], inputTokens[2], inputTokens[3], double.Parse(inputTokens[4]), privates));
                        break;
                    case "Commando":
                        if (inputTokens[5] != "Airforces" && inputTokens[5] != "Marines")
                        {
                            break;
                        }
                        var missions = ExtractMissions(inputTokens.Skip(6).ToList());
                        army.Add(new Commando(inputTokens[1], inputTokens[2], inputTokens[3], double.Parse(inputTokens[4]), inputTokens[5],missions));
                        break;
                    case "Engineer":
                        var parts = ExtractParts(inputTokens.Skip(6).ToList());
                        army.Add(new Engineer(inputTokens[1], inputTokens[2], inputTokens[3], double.Parse(inputTokens[4]), inputTokens[5], parts));
                        break;
                }
                
            }
            foreach (var soldier in army)
            {
                Console.WriteLine(soldier);
            }
        }

        private static IList<IRepair> ExtractParts(IList<string> parts)
        {
            var list = new List<IRepair>();
            for (int i = 0; i < parts.Count - 1; i += 2)
            {
                list.Add(new Repair(parts[i], int.Parse(parts[i + 1])));
            }

            return list;
        }

        private static IList<IMission> ExtractMissions(IList<string> missions)
        {
            var list = new List<IMission>();
            for (int i = 0; i < missions.Count-1; i+=2)
            {
                if (missions[i + 1] != "inProgress" && missions[i + 1] != "Finished")
                {
                    continue;                    
                }
                list.Add(new Mission(missions[i],missions[i+1]));
            }

            return list;
        }

        private static IList<ISoldier> ExtractPrivates(IList<string> soldiers)
        {
            var list = new List<ISoldier>();
            foreach (var soldier in soldiers)
            {
                list.Add(army.FirstOrDefault(s=>s.Id==soldier));   
            }
            return list;
        }
    }
}
