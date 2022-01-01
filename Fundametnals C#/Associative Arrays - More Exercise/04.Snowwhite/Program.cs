using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Snowwhite
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, int> dwarfs = new Dictionary<string, int>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] parts = input.Split(" <:> ");

                string dwarfName = parts[0];
                string hairColor = parts[1];
                int physics = int.Parse(parts[2]);

                string key = $"({hairColor}) {dwarfName}";

                if (!dwarfs.ContainsKey(key))
                {
                    dwarfs.Add(key, 0);
                }

                if (dwarfs[key] < physics)
                {
                    dwarfs[key] = physics;
                }
            }

            StringBuilder output = new StringBuilder();
            foreach (var dwarf in dwarfs.OrderByDescending(kvp => kvp.Value)
                .ThenByDescending(c => dwarfs.Where(kvp => kvp.Key.Split(")")[0] == c.Key.Split(")")[0]).Count()))
            {
                output.AppendLine($"{dwarf.Key} <-> {dwarf.Value}");
            }

            Console.WriteLine(output.ToString());
        }
    }
}
