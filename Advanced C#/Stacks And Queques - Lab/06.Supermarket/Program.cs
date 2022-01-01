using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>();
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                if (input == "Paid")
                {
                    while (people.Any())
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                }
                else
                {
                    people.Enqueue(input);
                }
            }
            Console.WriteLine(people.Count+" people remaining.");
        }
    }
}
