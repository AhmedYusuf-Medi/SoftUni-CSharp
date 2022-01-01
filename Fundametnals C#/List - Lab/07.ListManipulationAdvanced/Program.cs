using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                     .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                     .Select(int.Parse)
                     .ToList();
            string input = String.Empty;

            bool isChanged = false;
            while ((input = Console.ReadLine().ToLower()) != "end")
            {
                string[] arg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string command = arg[0];
                int number;
                switch (command)
                {
                    case "add":
                         number = int.Parse(arg[1]);
                        numbers.Add(number);
                        isChanged = true;
                        break;
                    case "remove":
                         number = int.Parse(arg[1]);
                        numbers.Remove(number);
                        isChanged = true;
                        break;
                    case "removeat":
                         number = int.Parse(arg[1]);
                        numbers.RemoveAt(number);
                        isChanged = true;
                        break;
                    case "insert":
                         number = int.Parse(arg[1]);
                        int index = int.Parse(arg[2]);
                        numbers.Insert(index, number);
                        isChanged = true;
                        break;
                    case "contains":
                         number = int.Parse(arg[1]);
                        if (numbers.Contains(number))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "printeven":
                        Console.WriteLine(string.Join(' ',numbers.Where(n => n % 2 == 0)));
                        break;
                    case "printodd":
                        Console.WriteLine(string.Join(' ',numbers.Where(n => n % 2 ==1)));
                        break;
                    case "getsum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "filter":
                        string condition = arg[1];
                        number = int.Parse(arg[2]);
                        if (condition == ">")
                        {
                            Console.WriteLine(string.Join(' ',numbers.Where(n => n > number)));
                        }
                        else if (condition == "<")
                        {
                            Console.WriteLine(string.Join(' ', numbers.Where(n => n < number)));
                        }
                        else if (condition == ">=")
                        {
                            Console.WriteLine(string.Join(' ', numbers.Where(n => n >= number)));
                        }
                        else
                        {
                            Console.WriteLine(string.Join(' ', numbers.Where(n => n <= number)));
                        }
                        break;
                    default:
                        break;
                }
            }

            if (isChanged)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
