using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _14.Dragon_Army
{
    class Program
    {
        private const int DefaultDamage = 45;
        private const int DefaultHealth = 250;
        private const int DefaultArmor = 10;
        static void Main()
        {
            var allDragons = new Dictionary<string,SortedDictionary<string,int[]>>();

            var numberOfDragons = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfDragons; i++)
            {
                var dragon = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries);
                var dragonType = dragon[0];
                var dragonName = dragon[1];
                var dragonDmg = dragon[2].Equals("null") ? DefaultDamage : int.Parse(dragon[2]);
                var dragonHealth = dragon[3].Equals("null") ? DefaultHealth : int.Parse(dragon[3]);
                var dragonArmor = dragon[4].Equals("null") ? DefaultArmor : int.Parse(dragon[4]);
                if (allDragons.ContainsKey(dragonType))
                {
                    allDragons[dragonType][dragonName] = new int[] {dragonDmg, dragonHealth, dragonArmor};
                }
                else
                {
                    allDragons[dragonType]=new SortedDictionary<string, int[]>(){{dragonName,new []{dragonDmg,dragonHealth,dragonArmor}}};
                }
            }

            Print(allDragons);
        }

        private static void Print(Dictionary<string, SortedDictionary<string, int[]>> allDragons)
        {

            foreach (var dragonType in allDragons)
            {
                var dragonTypeinfo = new StringBuilder();
                double averageDmg = 0, avrHealth = 0, avrArmor = 0;
                foreach (var dragon in dragonType.Value)
                {
                    dragonTypeinfo.Append(
                        $"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}\r\n");
                    averageDmg += dragon.Value[0];
                    avrHealth += dragon.Value[1];
                    avrArmor += dragon.Value[2];
                }
                averageDmg /= dragonType.Value.Count;
                avrHealth /= dragonType.Value.Count;
                avrArmor /= dragonType.Value.Count;
                Console.WriteLine($"{dragonType.Key}::({averageDmg:f2}/{avrHealth:f2}/{avrArmor:f2})");
                Console.Write(dragonTypeinfo.ToString());
            }
        }
    }
}
