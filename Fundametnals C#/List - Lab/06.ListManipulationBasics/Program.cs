using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                                .Select(int.Parse)
                                .ToList();
            string input = String.Empty;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] arg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = arg[0];
                int number = int.Parse(arg[1]);
                switch (command)
                {
                    case "add":
                        numbers.Add(number);
                        break;
                    case "remove":
                        numbers.Remove(number);
                        break;
                    case "removeat":
                        numbers.RemoveAt(number);
                        break;
                    case "insert":
                        int index = int.Parse(arg[2]);
                        numbers.Insert(index,number);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}  