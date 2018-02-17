using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


    public  class Output
    {
        public  string GiveOutput(StringBuilder result, Dictionary<string, List<ISoldier>> army,
            Dictionary<string, List<IAmmunition>> wearHouse, int missionQueueCount)
        {
            var orderedArmy = army.OrderBy(x=>x.Value);
            int totalAmmunitions = 0;

            foreach (var team in orderedArmy)
            {
                result.Append(team.Value[0].ToString());
                result.AppendLine($"Average experience: {team.Value.Average(e => e.Experience):F2}");
                result.AppendLine($"Average power: {team.Value:F2}");
                result.Append("Soldiers: ");

                foreach (var soldier in team.Value)
                {
                    result.Append($"{soldier.Name} {soldier.Age}, ");
                }
                result.Remove(result.Length - 2, 2);
                result.AppendLine(Environment.NewLine);
            }

            //TODO: трябва да ги подредя, защото в момента се чупи
            //var orderedWearHouse = wearHouse.OrderBy(w => w.Value.OrderBy(q => q.Number));
            //result.AppendLine("Weapons:");

            //foreach (var weapons in orderedWearHouse)
            //{
            //    foreach (var weapon in weapons.Value)
            //    {
            //        result.AppendLine(weapon.ToString());
            //        totalAmmunitions += weapon.Number;
            //    }
            //}

            result.AppendLine($"Ammunitions left in total: {totalAmmunitions}");
            result.AppendLine($"Missions left in Queue: {missionQueueCount}");
            return result.ToString().Trim();
        }


        public  string MissionDeclined { get; set; }
        

        public  string MissionSuccessful { get; set; }
        

        public  string MissionOnHold { get; set; }
    }
