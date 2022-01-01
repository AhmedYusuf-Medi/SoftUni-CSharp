using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.SoftUniExamResults
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> languageAndSubmitions = new Dictionary<string, int>();
            Dictionary<string, int> usersAndPoints = new Dictionary<string, int>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "exam finished")
            {
                string[] parts = input.Split('-');

                string user = parts[0];

                if (!parts.Contains("banned"))
                {
                    string language = parts[1];
                    int points = int.Parse(parts[2]);

                    if (!usersAndPoints.ContainsKey(user))
                    {
                        usersAndPoints.Add(user, 0);
                    }

                    if (points > usersAndPoints[user])
                    {
                        usersAndPoints[user] = points;
                    }

                    if (!languageAndSubmitions.ContainsKey(language))
                    {
                        languageAndSubmitions.Add(language, 0);
                    }

                    languageAndSubmitions[language]++;
                }
                else
                {
                    if (usersAndPoints.ContainsKey(user))
                    {
                        usersAndPoints.Remove(user);
                    }
                }
            }

            StringBuilder output = new StringBuilder();
            output.AppendLine("Results:");
            foreach (var user in usersAndPoints.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
            {
                output.AppendLine($"{user.Key} | {user.Value}");
            }
            output.AppendLine("Submissions:");
            foreach (var language in languageAndSubmitions.OrderByDescending(n => n.Value)
                .ThenBy(n => n.Key))
            {
                output.AppendLine($"{language.Key} - {language.Value}");
            }

            Console.WriteLine(output.ToString());
        }
    }
}
