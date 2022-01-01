using System;
using System.Collections.Generic;
using System.Linq;

namespace _11.PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            List<string> filters = new List<string>();
            string text;

            while ((text = Console.ReadLine()) != "Print")

            {
                string[] input = text.Split(";",StringSplitOptions.RemoveEmptyEntries);
                string comand = input[0];
                string comandType = input[1];
                string arg = input[2];
                if (comand =="Add filter")
                {
                    filters.Add($"{comandType};{arg}");
                }
                else if (comand == "Remove filter")
                {
                    filters.Remove(text);
                }
            }

            foreach (var filter in filters)
            {
                string[] comand = filter.Split(";");
                string comandType = comand[0];
                string arg = comand[1];

                switch (comandType)
                {
                    case "Starts with":
                        people = people.Where(p => !p.StartsWith(arg)).ToList();
                        break;
                    case "Ends with":
                        people = people.Where(p => !p.EndsWith(arg)).ToList();
                        break;
                    case "Contains":
                        people = people.Where(p => !p.Contains(arg)).ToList();
                        break;
                    case "Lenght":
                        people = people.Where(p => p.Length != int.Parse(arg)).ToList();
                        break;
                    default:
                        break;
                }
            }

            if (people.Any())
            {
                Console.WriteLine(string.Join(' ', people));
            }

        }
    }
}
