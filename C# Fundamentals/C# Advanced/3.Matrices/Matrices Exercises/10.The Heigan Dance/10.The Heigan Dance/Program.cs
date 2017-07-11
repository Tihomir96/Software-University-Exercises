using System;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace _10.The_Heigan_Dance
{
    class Program
    {
        public class HeiganDance
        {
            private const int ChamberSize = 15;
            private const int CloudDamage = 3500;
            private const int EruptionDamage = 6000;
            private const double PlayerHealth = 18500;
            private const double HeiganHealth = 3000000;
        

        public static void Main()
            {
                var playerPosition = new int[] {ChamberSize / 2, ChamberSize / 2};
                var heiganPoints = HeiganHealth;
                var playerPoints = PlayerHealth;
                var damageToHeigan = double.Parse(Console.ReadLine());
                var isHeiganDead = false;
                var isPlayerDead = false;
                var hasCloud = false;   
                var lastSpell = "";
                while (true)
                {
                    var spellTokens = Console.ReadLine().Split();
                    var spell = spellTokens[0];
                    var spellRow = int.Parse(spellTokens[1]);
                    var spellCol = int.Parse(spellTokens[2]);
                    heiganPoints -= damageToHeigan;
                    isHeiganDead = heiganPoints <= 0;
                    if (hasCloud)
                    {
                        playerPoints -= CloudDamage;
                        hasCloud = false;
                        isPlayerDead = playerPoints <= 0;                 
                    }
                    if (isHeiganDead || isPlayerDead)
                    {
                        break;
                    }
                    if (IsPlayerInDmgZone(playerPosition,spellRow,spellCol))
                    {
                        if (!PlayerTryEscape(playerPosition, spellCol, spellRow))
                        {
                            switch (spell)
                            {
                                case "Cloud":
                                    playerPoints -= CloudDamage;
                                    hasCloud = true;
                                    lastSpell = "Plague Cloud";
                                    break;
                                case "Eruption":
                                    playerPoints -= EruptionDamage;
                                    lastSpell = spell;
                                    break;
                                    
                            }
                        }
                    }
                    isPlayerDead = playerPoints <= 0;
                    if (isPlayerDead)
                    {
                        break;                        
                    }
                }
                PrintResult(playerPosition, heiganPoints, playerPoints, lastSpell);
            }

            private static void PrintResult(int[] playerPosition, double heiganPoints, double playerPoints, string lastSpell)
            {
                if (heiganPoints <= 0)
                {
                    Console.WriteLine($"Heigan: Defeated!");
                }
                else
                {
                    Console.WriteLine($"Heigan: {heiganPoints:f2}");
                }
                if (playerPoints <= 0)
                {
                    Console.WriteLine($"Player: Killed by {lastSpell}");
                }
                else
                {
                    Console.WriteLine($"Player: {playerPoints}");
                }
                Console.WriteLine($"Final position: {playerPosition[0]}, {playerPosition[1]}");
            }

            private static bool PlayerTryEscape(int[] playerPosition, int spellCol, int spellRow)
            {
                if (playerPosition[0] - 1 >= 0 && playerPosition[0] - 1 < spellRow - 1)
                {
                    playerPosition[0]--;
                    return true;
                }
                else if(playerPosition[1]+1<ChamberSize && playerPosition[1]+1> spellCol+1)
                {
                    playerPosition[1]++;
                    return true;
                }
                else if (playerPosition[0] + 1 < ChamberSize && playerPosition[0] + 1 > spellRow + 1)
                {
                    playerPosition[0]++;
                    return true;
                }
                else if (playerPosition[1] - 1 >= 0 && playerPosition[1] - 1 < spellCol - 1)
                {
                    playerPosition[1]--;
                    return true;
                }
                return false;                
            }

            private static bool IsPlayerInDmgZone(int[] playerPosition, int spellRow, int spellCol)
            {
                bool isHitRow = playerPosition[0] >= spellRow - 1 && playerPosition[0] <= spellRow + 1;
                bool isHitCol = playerPosition[1] >= spellCol - 1 && playerPosition[1] <= spellCol + 1;

                return isHitCol && isHitRow;
            }
        }
    }
}
