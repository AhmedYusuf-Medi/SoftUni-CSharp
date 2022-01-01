using System;
using System.Collections.Generic;

namespace FootballTeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = new Dictionary<string, Team>();

            string line;
            while ((line = Console.ReadLine()) != "END")
            {
                var arg = line.Split(";");
                var comand = arg[0];
                var teamName = arg[1];

                try
                {
                    if (comand == "Add")
                    {
                            if (!teams.ContainsKey(teamName))
                            {
                                Console.WriteLine($"Team [{teamName}] does not exist.");
                            }
                            var playerName = arg[2];
                        var endurance = int.Parse(arg[3]);
                        var sprint = int.Parse(arg[4]);
                        var dribble = int.Parse(arg[5]);
                        var passing = int.Parse(arg[6]);
                        var shooting = int.Parse(arg[7]);

                        var currTeam = teams[teamName];

                        Player player = new Player(playerName, endurance, sprint
                            , dribble, passing, shooting);

                        currTeam.AddPlayer(player);
                    }
                    else if (comand == "Remove")
                    {
                        var playerName = arg[2];

                        teams[teamName].RemovePlayer(playerName);
                    }
                    else if (comand == "Team")
                    {
                        var team = new Team(teamName);
                        teams.Add(teamName, team);
                    }
                    else if (comand == "Rating")
                    {
                        if (!teams.ContainsKey(teamName))
                        {
                            Console.WriteLine($"Team {teamName} does not exist.");
                            continue;
                        }

                        Console.WriteLine($"{teamName} - {teams[teamName].AverageTeamRating}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
