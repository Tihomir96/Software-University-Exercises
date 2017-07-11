namespace _4.Champions_League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;    
    class Program
    {
        static void Main()
        {
            var dict = new Dictionary<string, Opponents>();
            string input;
            while ((input = Console.ReadLine()) != "stop")
            {
                var tokens = input.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                var team1 = tokens[0].Trim();
                var team2 = tokens[1].Trim();
                var firstResult = tokens[2].Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var secondResult = tokens[3].Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                var finalResultT1 = int.Parse(firstResult[0]) + 2 * int.Parse(secondResult[1]);
                var finalResultT2 = 2 * int.Parse(firstResult[1]) + int.Parse(secondResult[0]);
                if (finalResultT1 > finalResultT2)
                {
                    if (!dict.ContainsKey(team1))
                    {
                        var oponentsWinner = new Opponents();
                        oponentsWinner.opponents = new List<string>();
                        oponentsWinner.opponents.Add(team2);
                        oponentsWinner.wins++;
                        var oponentsLooser = new Opponents();
                        oponentsLooser.opponents = new List<string>();
                        oponentsLooser.opponents.Add(team1);
                        dict.Add(team1, oponentsWinner);
                        if (dict.ContainsKey(team2))
                        {
                            dict[team2].opponents.Add(team1);
                        }
                        else
                        {
                            dict.Add(team2, oponentsLooser);
                        }
                    }
                    else
                    {
                        dict[team1].opponents.Add(team2);
                        dict[team1].wins++;
                        if (dict.ContainsKey(team2))
                        {
                            dict[team2].opponents.Add(team1);
                        }
                        else
                        {
                            var opponentsLooser = new Opponents();
                            opponentsLooser.opponents = new List<string>();
                            opponentsLooser.opponents.Add(team1);
                            dict.Add(team2, opponentsLooser);
                        }
                    }
                }
                else
                {
                    if (!dict.ContainsKey(team2))
                    {
                        var oponentsWinner = new Opponents();
                        oponentsWinner.opponents = new List<string>();
                        oponentsWinner.opponents.Add(team1);
                        oponentsWinner.wins++;
                        var oponentsLooser = new Opponents();
                        oponentsLooser.opponents = new List<string>();
                        oponentsLooser.opponents.Add(team2);
                        dict.Add(team2, oponentsWinner);
                        if (dict.ContainsKey(team1))
                        {

                            dict[team1].opponents.Add(team2);
                        }
                        else
                        {
                            dict.Add(team1, oponentsLooser);
                        }
                    }
                    else
                    {
                        dict[team2].opponents.Add(team1);
                        dict[team2].wins++;
                        if (dict.ContainsKey(team1))
                        {
                            dict[team1].opponents.Add(team2);
                        }
                        else
                        {
                            var opponentsLooser = new Opponents();
                            opponentsLooser.opponents = new List<string>();
                            opponentsLooser.opponents.Add(team2);
                            dict.Add(team1, opponentsLooser);
                        }
                    }

                }
            }
            foreach (var team in dict.OrderByDescending(x => x.Value.wins).ThenBy(x => x.Key))
            {
                Console.WriteLine(team.Key);
                Console.WriteLine($"- Wins: {team.Value.wins}");
                Console.WriteLine($"- Opponents: {string.Join(", ", team.Value.opponents.OrderBy(x => x))}");
            }
        }
        class Opponents
        {
            public List<string> opponents { get; set; }
            public int wins { get; set; }
        }
    }
}