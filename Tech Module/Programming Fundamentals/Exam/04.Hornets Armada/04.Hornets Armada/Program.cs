using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornets_Armada
{
    class Program
    {
        static void Main()
        {
            var legionDict = new Dictionary<string, LegionProp>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var split = input.Split(new[] { ' ', '=', '-', '>',':'}, StringSplitOptions.RemoveEmptyEntries);
                var lastActivity = int.Parse(split[0]);
                var legionName = split[1];
                var soldierType = split[2];
                var soldierCount = split[3];
                if (!legionDict.ContainsKey(legionName))
                {
                    var legionProp = new LegionProp();
                    legionProp.LastActivity = lastActivity;
                    legionProp.SoldierType.Add(soldierType,lastActivity);
                    legionProp.SoldierCount = long.Parse(soldierCount);
                
                    legionDict.Add(legionName, legionProp);
                }
                else
                {
                    var legionProp = new LegionProp();

                    if (legionDict[legionName].SoldierType.ContainsKey(soldierType))
                    {
                        legionProp.SoldierType[soldierType] = lastActivity;
                        legionProp.SoldierCount += long.Parse(soldierCount);
                    }else
                    {
                        if (legionProp.SoldierType.ContainsKey(soldierType))
                        {
                            legionProp.SoldierCount += long.Parse(soldierCount);
                        legionProp.SoldierType.Add(soldierType,lastActivity);
                        }else
                        {
                            legionProp.SoldierType.Add(soldierType, lastActivity);
                            legionProp.SoldierCount += long.Parse(soldierCount);

                        }
                        
                    }
                    if (lastActivity > legionDict[legionName].LastActivity)
                    {

                    legionDict[legionName].LastActivity = lastActivity;
                    }
                    legionDict[legionName].SoldierType.Add(soldierType, int.Parse(soldierCount));
                 

                }

            }
            var newInput = Console.ReadLine();
            long newActivity;
            if (newInput.Contains("\\"))
            {
                var newSplit = newInput.Split('\\');
                 newActivity= long.Parse(newSplit[0]);
                var newSoldierType = newSplit[1];
                foreach (var kvp in legionDict.OrderByDescending(x=>x.Value.SoldierCount))
                {
                    if(kvp.Value.SoldierType.ContainsKey(newSoldierType) && kvp.Value.LastActivity < newActivity)
                    {
                        Console.WriteLine($"{kvp.Key} -> {kvp.Value.SoldierCount}");
                    }
                }
            }
            else
            {
                var newSoldierType = newInput;
                foreach (var kvp in legionDict)
                {
                    if (kvp.Value.SoldierType.ContainsKey(newSoldierType))
                    {
                        Console.WriteLine($"{kvp.Value.SoldierCount} : {kvp.Key}");
                    }
               }
               }

            
        }
        class LegionProp
        {
            public int LastActivity { get; set; }
            public Dictionary<string, long> SoldierType { get; set; } = new Dictionary<string, long>();
            public long SoldierCount { get; set; }
        }
    }
}
