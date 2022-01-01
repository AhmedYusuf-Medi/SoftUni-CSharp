using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().Split(", ").ToArray();
            Queue<string> queue = new Queue<string>(sequence);

            var input = Console.ReadLine();

            while (queue.Any())
            {
                if (input.Contains("Play"))
                {
                    queue.Dequeue();
                }
                else if (input.Contains("Add"))
                {
                    var arg = input.Split("Add ",StringSplitOptions.RemoveEmptyEntries);
                    if (queue.Contains(arg[0]))
                    {
                        Console.WriteLine($"{arg[0]} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(arg[0]);
                    }
                }
                else if (input.Contains("Show"))
                {
                    Console.WriteLine(string.Join(", ", queue));
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("No more songs!");
        }
    }
}
