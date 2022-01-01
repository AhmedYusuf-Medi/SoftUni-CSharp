using System;
using System.Collections.Generic;

namespace _04.CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] arg = Console.ReadLine().Split();
                string continet = arg[0];
                string country = arg[1];
                string city = arg[2];

                if (!continents.ContainsKey(continet))
                {
                    continents.Add(continet, new Dictionary<string, List<string>>());
                }
                if (!continents[continet].ContainsKey(country))
                {
                    continents[continet][country] = new List<string>();
                }
                continents[continet][country].Add(city);
            }

            foreach (var continet in continents)
            {
                Console.WriteLine(continet.Key+ ":");
                foreach (var country in continet.Value)
                {
                    Console.Write($"   {country.Key} -> ");
                    Console.WriteLine(string.Join(", ",country.Value));
                }

            }
        }
    }
}
