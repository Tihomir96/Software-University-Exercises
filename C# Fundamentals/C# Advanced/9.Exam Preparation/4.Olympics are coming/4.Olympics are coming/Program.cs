using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Olympics_are_coming
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var dict = new Dictionary<string,Participants>();
                string country = string.Empty;
            string player = string.Empty;
            while (input != "report" && input!="Report")
            {
                var tokens = input.Split('|');               
                var playerTokens = tokens[0].Trim().Split(new char[]{' ' ,'\t', '\n'},StringSplitOptions.RemoveEmptyEntries);
                if (playerTokens.Length > 1)
                {
                    for (int i = 0; i < playerTokens.Length; i++)
                    {
                        player += playerTokens[i] + ' ';
                    }
                }
                else
                {
                    player = playerTokens[0];
                }

                player =player.Trim();
                var countryTokens = tokens[1].Trim().Split(new char[]{' ','\t','\n'},StringSplitOptions.RemoveEmptyEntries);
                if (countryTokens.Length > 1)
                {
                    for (int i = 0; i < countryTokens.Length; i++)
                    {
                        country += countryTokens[i] + ' ';
                    }
                }
                else
                {
                    country = countryTokens[0];
                }
                country =country.Trim();

                if (dict.ContainsKey(country))
                {
                    
                    if (dict[country].participants.ContainsKey(player))
                    {
                        dict[country].participants[player]++;
                    }
                    else
                    {
                        dict[country].participants.Add(player, 1);
                    }
                }
                else
                {
                    var newParticipant = new Participants();
                    newParticipant.participants=new Dictionary<string, int>();
                    newParticipant.participants.Add(player,1);
                    dict.Add(country,newParticipant);
                }
                player = string.Empty;
                country = string.Empty;
                input = Console.ReadLine();
            }
            foreach (var countr in dict.OrderByDescending(x=> x.Value.participants.Values.Sum()))
            {
                Console.WriteLine($"{countr.Key} ({countr.Value.participants.Keys.Count} participants): {countr.Value.participants.Values.Sum()} wins");
                
            }
        }
        class Participants
        {
            public Dictionary<string, int> participants { get; set; }
        }
    }
}
