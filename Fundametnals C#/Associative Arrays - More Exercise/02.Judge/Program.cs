using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _02.Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> users = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> individualStandings = new Dictionary<string, Dictionary<string, int>>();
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] parts = input.Split(" -> ");
                string user = parts[0];
                string contest = parts[1];
                int points = int.Parse(parts[2]);

                if (!users.ContainsKey(contest))
                {
                    users.Add(contest, new Dictionary<string, int>());
                }

                if (!users[contest].ContainsKey(user))
                {
                    users[contest].Add(user, 0);
                }

                if (users[contest][user] < points)
                {
                    users[contest][user] = points;
                }
                if (!individualStandings.ContainsKey(user))
                {
                    individualStandings.Add(user, new Dictionary<string, int>());
                }

                if (!individualStandings[user].ContainsKey(contest))
                {
                    individualStandings[user].Add(contest, 0);
                }

                if (individualStandings[user][contest] < points)
                {
                    individualStandings[user][contest] = points;
                }


            }

            StringBuilder output = new StringBuilder();

            int counter = 1;
            foreach (var user in users)
            {
                output.AppendLine($"{user.Key}: {user.Value.Count} participants");

                foreach (var contest  in user.Value.OrderByDescending(points => points.Value).ThenBy(kvp => kvp.Key))
                {
                    output.AppendLine($"{counter}. {contest.Key} <::> {contest.Value}");
                    counter++;
                }
                counter = 1;
            }

            output.AppendLine("Individual standings:");



            foreach (var student in individualStandings.OrderByDescending(kvp => kvp.Value.Values.Sum()).ThenBy(kvp => kvp.Key))
            {
                output.AppendLine($"{counter}. {student.Key} -> {student.Value.Values.Sum()}");
                counter++;
            }

            Console.WriteLine(output.ToString());
        }
    }
}
