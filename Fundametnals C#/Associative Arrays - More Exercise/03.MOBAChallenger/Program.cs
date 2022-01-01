using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03.MOBAChallenger
{
    class Program
    { 

        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> statistics 
                = new Dictionary<string, Dictionary<string, int>>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "Season end") 
            {
                string[] parts = new string[input.Length];
                if (input.Contains(" -> "))
                {
                    parts = input.Split(" -> ");
                    string playerName = parts[0];
                    string position = parts[1];
                    int skills = int.Parse(parts[2]);

                    if (!statistics.ContainsKey(playerName))
                    {
                        statistics.Add(playerName, new Dictionary<string, int>());
                    }

                    if (!statistics[playerName].ContainsKey(position))
                    {
                        statistics[playerName].Add(position, 0);
                    }

                    if (statistics[playerName][position] < skills)
                    {
                        statistics[playerName][position] = skills;
                    }
                }
                else if (input.Contains("vs"))
                {
                    parts = input.Split(" vs ");
                    string firstPlayer = parts[0];
                    string secondPlayer = parts[1];

                    if (statistics.ContainsKey(firstPlayer) && statistics.ContainsKey(secondPlayer))
                    {
                        foreach (var position in statistics[firstPlayer].Keys)
                        {
                            if (statistics[secondPlayer].ContainsKey(position))
                            {
                                if (statistics[firstPlayer].Values.Sum() > statistics[secondPlayer].Values.Sum())
                                {
                                    statistics.Remove(secondPlayer);
                                }
                                else if ((statistics[firstPlayer].Values.Sum() < statistics[secondPlayer].Values.Sum()))
                                {
                                    statistics.Remove(firstPlayer);
                                }
                                break;
                            }
                        }
                    }
                }
            }

            StringBuilder output = new StringBuilder();
            foreach (var player in statistics.OrderByDescending(kvp => kvp.Value.Values.Sum()).ThenBy(kvp => kvp.Key))
            {
               output.AppendLine($"{player.Key}: {player.Value.Values.Sum()} skill");

                foreach (var kvp in player.Value.OrderByDescending(kvp => kvp.Value).ThenBy(kvp => kvp.Key))
                {
                    output.AppendLine($"- {kvp.Key} <::> {kvp.Value}");
                }
            }

            Console.WriteLine(output.ToString());
        }
    }
}
