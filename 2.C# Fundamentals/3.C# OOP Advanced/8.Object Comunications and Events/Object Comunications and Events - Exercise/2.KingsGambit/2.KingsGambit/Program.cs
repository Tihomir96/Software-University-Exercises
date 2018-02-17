using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.KingsGambit
{
    public class Program
    {
        public static void Main()
        {
            List<Soldier> army = new List<Soldier>();
            var kingName = Console.ReadLine();
            var king = new King(kingName);
            var royalGuards = Console.ReadLine().Split();
            foreach (var royalGuard in royalGuards)
            {
                var guard = new RoyalGuard(royalGuard);
                army.Add(guard);
                king.UnderAtack += guard.KingUnderAtack;
            }
            var footmans = Console.ReadLine().Split();
            foreach (var footman in footmans)
            {
                var footMan = new Footman(footman);
                army.Add(footMan);
                king.UnderAtack += footMan.KingUnderAtack;
            }
            string cmd;
            while ((cmd=Console.ReadLine())!="End")
            {
                var cmdTokens = cmd.Split();

                switch (cmdTokens[0])
                {
                    case "Kill":
                        var soldier = army.FirstOrDefault(x => x.Name == cmdTokens[1]);
                        king.UnderAtack -= soldier.KingUnderAtack;
                        army.Remove(soldier);
                        break;
                    case "Attack":
                        king.OnUnderAtack();
                        break;                        
                }
            }
        }
    }
}
