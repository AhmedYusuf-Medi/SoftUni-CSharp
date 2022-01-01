using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            for (int i = 0; i < teamsCount; i++)
            {
                string[] info = Console.ReadLine().Split("-");
                string creator = info[0];
                string teamName = info[1];

                if (teams.Any(x=>x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(x=>x.Creator== creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                Team team = new Team(teamName,creator);
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }
            string command = String.Empty;
            while ((command = Console.ReadLine())!= "end of assignment")
            {
                string[] info = command.Split("->");
                string user = info[0];
                string teamName = info[1];

                if (!teams.Any(x=>x.TeamName==teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }
                if (teams.Any(x=>x.Members.Contains(user) || x.Creator == user && x.TeamName== teamName))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamName}!");
                    continue;
                }

                int index = teams.FindIndex(x => x.TeamName == teamName);
                teams[index].Members.Add(user);
            }
            var disband = teams.FindAll(x => x.Members.Count == 0).OrderBy(x=>x.TeamName).ToList();
            var valid = teams.FindAll(x=>x.Members.Count>0).OrderBy(x => x.TeamName).ToList();

            Console.WriteLine(string.Join(Environment.NewLine,valid.
                OrderByDescending(x=>x.Members.Count).
                ThenBy(x=>x.TeamName)));

            Console.WriteLine("Teams to disband:");
            foreach (var team in disband)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
    class Team
    {
        public Team(string teamName, string creator)
        {
            TeamName = teamName;
            Creator = creator;
            Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(TeamName);
            sb.AppendLine("- " + Creator);

            foreach (var member in Members)
            {
                sb.AppendLine("-- " + member);
            }
            return sb.ToString().TrimEnd();
        }
    }
}
