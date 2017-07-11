using System;
using System.Collections.Generic;
using System.Linq;
namespace _09.Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var teamsDictionary = new Dictionary<string, Team>();
            var input = Console.ReadLine();

            while (teamsDictionary.Count<= n)
            {
                var line = input.Split('-');

                var name = line[0];
                var teamName = line[1];


                if (teamName.StartsWith(">"))
                {
                    var memberName = name;
                    teamName = teamName.Substring(1);
                    if (teamsDictionary.ContainsKey(teamName))
                    {
                        if (MemberCannotJoin(teamsDictionary, memberName))
                        {
                            Console.WriteLine($"Member {memberName} cannot join team {teamName}!");
                        }
                        else

                        {
                            Team currentTeam = teamsDictionary[teamName];
                            currentTeam.Members.Add(memberName);

                        }
                    }
                    else
                    {
                        Console.WriteLine($"Team {teamName} does not exist!");
                    }
                }
                else
                {
                    if (teamsDictionary.ContainsKey(teamName))
                    {
                        Console.WriteLine($"Team {teamName} was already created!");

                    }
                    else
                    {
                        var creatorName = name;
                        if (CreatorExist(teamsDictionary, creatorName))
                        {
                            Console.WriteLine($"{creatorName} cannot create another team!");

                        }
                        else
                        {
                           // if (teamsDictionary.Count <= n)
                            //{
                                var team = new Team();
                                team.TeamName = teamName;
                                Console.WriteLine($"Team {teamName} has been created by {name}!");
                                team.CreatorName = creatorName;
                                teamsDictionary.Add(teamName, team);
                          //  }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            var filteredTeams = teamsDictionary.Where(m => m.Value.Members.Count > 0);
            foreach (var item in filteredTeams.OrderByDescending(m => m.Value.Members.Count))
            {
                Console.WriteLine(item.Key);
                Console.WriteLine($"- {item.Value.CreatorName}");
                foreach (var member in item.Value.Members.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            var teamsToDisband = teamsDictionary.Where(m => m.Value.Members.Count == 0);
            Console.WriteLine("Teams to disband:");
            foreach (var item in teamsToDisband.OrderBy(t => t.Key))
            {
                Console.WriteLine(item.Key);
            }


        }

        public static bool CreatorExist(Dictionary<string, Team> teamsDictionary, string creatorName)
        {
            foreach (var item in teamsDictionary)
            {
                if (item.Value.CreatorName == creatorName || item.Value.Members.Contains(creatorName))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool MemberCannotJoin(Dictionary<string, Team> teamsDictionary, string memberName)
        {
            foreach (var item in teamsDictionary)
            {
                if (item.Value.Members.Contains(memberName) || item.Value.CreatorName == memberName)
                {
                    return true;
                }

            }
            return false;
        }
    }
}
