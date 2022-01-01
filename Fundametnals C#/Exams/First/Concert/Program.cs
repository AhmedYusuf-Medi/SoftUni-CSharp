using System;
using System.Collections.Generic;
using System.Linq;

namespace Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> bandAndMembers 
                = new Dictionary<string, List<string>>();

            Dictionary<string, int> bandsTime = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "start of concert")
                {
                    break;
                }

                string[] arg = line.Split("; ");

                string comand = arg[0];
                AddBandsAndTheirTime(bandAndMembers, bandsTime, arg, comand);
            }

            string bandToPrint = Console.ReadLine();

            //Print the total time of all bands
            int totalTime = bandsTime.Sum(b => b.Value);

            Console.WriteLine($"Total time: {totalTime}");

            //Print bands in descending order by time then by name
            bandsTime = bandsTime.OrderByDescending(b => b.Value).ThenBy(b => b.Key)
                .ToDictionary(k =>k.Key , v=>v.Value);

            foreach (var band in bandsTime)
            {
                Console.WriteLine($"{band.Key} -> {band.Value}");
            }

            //Print the band 
            Console.WriteLine(bandToPrint);

            foreach (var member in bandAndMembers[bandToPrint])
            {
                Console.WriteLine($"=> {member}");
            }
       }

        private static void AddBandsAndTheirTime(Dictionary<string, List<string>> bandAndMembers, Dictionary<string, int> bandsTime, string[] arg, string comand)
        {
            //Add band and members
            if (comand == "Add")
            {
                string bandName = arg[1];
                string[] members = arg[2].Split(", ");

                if (!bandAndMembers.ContainsKey(bandName))
                {
                    bandAndMembers[bandName] = new List<string>();
                }
                foreach (var member in members)
                {
                    if (!bandAndMembers[bandName].Contains(member))
                    {
                        bandAndMembers[bandName].Add(member);
                    }
                }
            }

            //Add time to bands
            else if (comand == "Play")
            {
                string bandName = arg[1];
                int time = int.Parse(arg[2]);

                if (!bandsTime.ContainsKey(bandName))
                {
                    bandsTime.Add(bandName, 0);
                }

                bandsTime[bandName] += time;
            }
        }
    }
}
