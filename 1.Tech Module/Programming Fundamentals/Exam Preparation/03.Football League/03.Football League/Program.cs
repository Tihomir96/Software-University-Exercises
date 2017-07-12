using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Program
    {
        
    class Team
        {
            public string Name { get; set; }
            public int Goals { get; set; }
            public int Points { get; set; }

        }
    

    static void Main()
        {
            var key = Console.ReadLine();
            var input = Console.ReadLine();


            var dict = new Dictionary<string, Team>();

            while (input != "final")
            {

                string[] encryptedGame = input.Split(' ');
                var teamA = Decrypt(encryptedGame[0], key);
                var teamB = Decrypt(encryptedGame[1], key);
                var result = encryptedGame[2].Split(':');
                
                var goalsA =int.Parse( result[0]); 
                var goalsB = int.Parse(result[1]); 


                if (!dict.ContainsKey(teamA))
                {
                    var team = new Team();
                    team.Name = teamA;
                    team.Goals = goalsA;
                    team.Points = winOrDrawOrLostA(goalsA ,goalsB);
                    dict.Add(teamA, team);
                }
                else
                {
                    dict[teamA].Goals += goalsA;
                    dict[teamA].Points += winOrDrawOrLostA(goalsA,goalsB);
                    
                }
                if (!dict.ContainsKey(teamB))
                {
                    var team = new Team();

                    team.Name = teamB;
                    team.Goals =goalsB;
                    team.Points = winOrDrawOrLostB(goalsA,goalsB);
                    dict.Add(teamB, team);
                }
                else
                {
                    dict[teamB].Goals += goalsB;
                    dict[teamB].Points += winOrDrawOrLostB(goalsA,goalsB);
                }
                
                input = Console.ReadLine();
            }
            var dict1 = dict.OrderByDescending(x => x.Value.Points).ThenBy(n => n.Value.Name);
            int place = 1;
            Console.WriteLine("League standings:");
            foreach (var team in dict1)
            {
                Console.WriteLine($"{place}. {team.Key} {team.Value.Points}");
                place++;
            }
            place = 1;
            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in dict1.OrderByDescending(g=>g.Value.Goals))
            {
                if (place > 3)
                {
                    break;
                }
                Console.WriteLine($"- {team.Key} -> {team.Value.Goals}");

                place++;
            }
            
        }

        private static int winOrDrawOrLostB( int goalsA , int goalsB)
        {
            if (goalsA < goalsB)
            {
                return 3;
            }
            else if (goalsA == goalsB)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private static int winOrDrawOrLostA(int goalsA, int goalsB)
        {

            if (goalsA > goalsB)
            {
                return 3;
            }
            else if (goalsA == goalsB)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private static string Decrypt(string encryptedName, string key)
        {
            var teamStart = encryptedName.IndexOf(key);
            var teamEnd = encryptedName.IndexOf(key, teamStart+ key.Length);
            var team = (encryptedName.Substring(teamStart + key.Length, teamEnd - (teamStart + key.Length)));

            return ReverseString(team);
        }

        private static string ReverseString(string maet)
        {

            string team = "";
            for (int i = maet.Length - 1; i >= 0; i--)
            {
                team += maet[i];

            }

            return team.ToUpper();
        }
    }
}
