using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();

            string text = String.Empty;

            while ((text = Console.ReadLine()) != "Party!")
            {
                string[] arg = text.Split();
                string comand = arg[0];
                string commandType = arg[1];
                string criteria = arg[2];

                var predicate = GetPredicate(commandType, criteria);

                switch (comand)
                {
                    case "Remove":
                        people.RemoveAll(predicate);
                        break;
                    case "Double":
                        List<string> matches = people.FindAll(predicate);

                        if (matches.Count > 0)
                        {
                            int index = people.FindIndex(predicate);
                            people.InsertRange(index, matches);
                        }

                        break;
                    default:
                        break;
                }
            }

            if (people.Count != 0)
            {
                Console.WriteLine(string.Join(", ",people) + "  are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }
        private static Predicate<string> GetPredicate(string commandType, string arg)
        {
            switch (commandType)
            {
                case "StartsWith":
                    return (name) => name.StartsWith(arg);
                case "EndsWith":
                    return (name) => name.EndsWith(arg);
                case "Length":
                    return (name) => name.Length == int.Parse(arg);
                default:
                    throw new ArgumentException("Invalid command type: " + commandType);
            }
        }
    }
}
