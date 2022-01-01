using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] neighbors = Console.ReadLine().Split("@").
                              Select(int.Parse).ToArray();

            string text = Console.ReadLine();

            int currIndex = 0;

            while (text != "Love!")
            {
                string[] arg = text.Split();

                string comand = arg[0];
                int index = int.Parse(arg[1]);

                currIndex += index;
                
                if (currIndex >= 0 && currIndex < neighbors.Length)
                {
                    neighbors[currIndex] -= 2;
                }

                else
                {
                    currIndex = 0;
                    neighbors[currIndex] -= 2;
 
                }

                if (neighbors[currIndex] == 0)
                {
                    Console.WriteLine($"Place {currIndex} has Valentine's day.");
                }

                else if (neighbors[currIndex] < 0)
                {
                    Console.WriteLine($"Place {currIndex} already had Valentine's day.");
                }

                text = Console.ReadLine();
            }

            Console.WriteLine($"Cupid's last position was {currIndex}.");

            int succesCount = neighbors.Count(x => x == 0);
            int failCount = neighbors.Count(x => x > 0);

            if (failCount == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {failCount} places.");
            }
        }
    }
}