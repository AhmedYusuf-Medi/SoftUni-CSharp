using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> forceUsers = new Dictionary<string, List<string>>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "Lumpawaroo")
            {
                string[] parts = new string[input.Length];
                if (input.Contains(" | "))
                {
                    parts = input.Split(" | ");
                    string forceSide = parts[0];
                    string forceUser = parts[1];

                    if (!forceUsers.ContainsKey(forceSide))
                    {
                        forceUsers.Add(forceSide, new List<string>());
                    }

                    if (!forceUsers.Any(users => users.Value.Contains(forceUser)))
                    {
                        forceUsers[forceSide].Add(forceUser);
                    }
                }
                else if (input.Contains(" -> "))
                {
                    parts = input.Split(" -> ");
                    string forceUser = parts[0];
                    string forceSide = parts[1];

                    if (!forceUsers.Any(users => users.Value.Contains(forceUser)))
                    {
                        if (!forceUsers.ContainsKey(forceSide))
                        {
                            forceUsers.Add(forceSide, new List<string>());
                        }
                    }
                    else
                    {
                        if (!forceUsers.ContainsKey(forceSide))
                        {
                            forceUsers.Add(forceSide, new List<string>());
                        }

                        foreach (var users in forceUsers.Values)
                        {
                            users.Remove(forceUser);
                        }
                    }
                    forceUsers[forceSide].Add(forceUser);
                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }
            foreach (var side in forceUsers.Where(kvp => kvp.Value.Count > 0)
                                      .OrderByDescending(kvp => kvp.Value.Count)
                                      .ThenBy(kvp => kvp.Key))
            {

                Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");

                foreach (var user in side.Value.OrderBy(n => n))
                {
                    Console.WriteLine($"! {user}");
                }
            }
        }
    }
}
