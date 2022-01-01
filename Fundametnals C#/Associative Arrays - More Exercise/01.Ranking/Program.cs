using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contestAndPassowrd = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, int>> usersResults = new Dictionary<string, Dictionary<string, int>>();
           
            SetContestsAndTheirPasswords(contestAndPassowrd);

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] parts = input.Split("=>");
                string contest = parts[0];
                string password = parts[1];
                string user = parts[2];
                int points = int.Parse(parts[3]);

                if (contestAndPassowrd.ContainsKey(contest) && contestAndPassowrd[contest] == password)
                {
                    if (!usersResults.ContainsKey(user))
                    {
                        usersResults.Add(user,new Dictionary<string, int>());
                    }

                    if (!usersResults[user].ContainsKey(contest))
                    {
                        usersResults[user].Add(contest, 0);       
                    }

                    if (usersResults[user][contest] < points)
                    {
                        usersResults[user][contest] = points;
                    }
                }
            }

            StringBuilder output = new StringBuilder();
            output.AppendLine(FindBestCandidate(usersResults));
            output.AppendLine("Ranking: ");
            foreach (var student in usersResults.OrderBy(user => user.Key))
            {
                output.AppendLine(student.Key);

                foreach (var contest in student.Value.OrderByDescending(kvp => kvp.Value))
                {
                    output.AppendLine($"#  {contest.Key} -> {contest.Value}");
                }
            }

            Console.WriteLine(output.ToString());
        }

        private static void SetContestsAndTheirPasswords(Dictionary<string, string> contestAndPassowrd)
        {
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] parts = input.Split(':');
                string contest = parts[0];
                string password = parts[1];

                if (!contestAndPassowrd.ContainsKey(contest))
                {
                    contestAndPassowrd.Add(contest, password);
                }
            }
        }

        private static string FindBestCandidate(Dictionary<string, Dictionary<string, int>> usersResults)
        {
            string bestCandidate = String.Empty;
            foreach (var user in usersResults.OrderByDescending(kvp => kvp.Value.Values.Sum()))
            {
                bestCandidate = $"Best candidate is {user.Key} with total {user.Value.Values.Sum()} points.";
                break;
            }

            return bestCandidate.ToString();
        }

    }
}
