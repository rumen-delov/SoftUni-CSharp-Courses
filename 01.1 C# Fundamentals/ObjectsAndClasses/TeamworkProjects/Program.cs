using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        public class Team
        {
            public Team()
            {
                Members = new List<string>();
            }

            public string Name { get; set; }

            public string Creator { get; set; }

            public List<string> Members { get; set; }
        }
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamsCount; i++)
            {
                string[] createTeamData = Console.ReadLine()
                    .Split('-', StringSplitOptions.RemoveEmptyEntries);

                string creator = createTeamData[0];
                string teamName = createTeamData[1];

                Team existingTeam = GetTeamByName(teams, teamName);

                if (existingTeam != null)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (CreatorExists(teams, creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                Team team = new Team()
                {
                    Creator = creator,
                    Name = teamName
                };

                teams.Add(team);

                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "end of assignment")
                {
                    break;
                }

                string[] joinTeamData = input
                    .Split("->", StringSplitOptions.RemoveEmptyEntries);

                string user = joinTeamData[0];
                string teamName = joinTeamData[1];

                Team existingTeam = GetTeamByName(teams, teamName);

                if (existingTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (IsMember(user, teams))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                existingTeam.Members.Add(user);
            }

            List<Team> sortedTeams = teams
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();

            foreach (Team team in sortedTeams)
            {
                if (team.Members.Count == 0)
                {
                    break;
                }
                
                Console.WriteLine($"{team.Name}");
                Console.WriteLine($"- {team.Creator}");

                List<string> sortedMembers = team.Members
                    .OrderBy(m => m)
                    .ToList();

                foreach (string member in sortedMembers)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            
            List<Team> disbandedTeams = teams
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();

            Console.WriteLine($"Teams to disband:");
            foreach (Team team in disbandedTeams)
            {
                Console.WriteLine(team.Name);
            }
        }

        private static Team GetTeamByName(List<Team> teams, string teamName)
        {
            foreach (var team in teams)
            {
                if (team.Name == teamName)
                {
                    return team;
                }
            }

            return null;
        }

        private static bool IsMember(string user, List<Team> teams)
        {
            foreach (var team in teams)
            {
                if (team.Creator == user)
                {
                    return true;
                }

                foreach (var member in team.Members)
                {
                    if (user == member)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private static bool CreatorExists(List<Team> teams, string creator)
        {
            foreach (var team in teams)
            {
                if (team.Creator == creator)
                {
                    return true;
                }              
            }

            return false;
        }

    }
}
