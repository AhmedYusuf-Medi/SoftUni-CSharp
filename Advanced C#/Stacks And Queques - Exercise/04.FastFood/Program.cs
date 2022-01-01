using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = int.Parse(Console.ReadLine());

            int[] nums = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Queue<int> result = new Queue<int>(nums);

            int max = result.Max();
            while (result.Any())
            {
                var food = result.Peek();

                if (food <= quantity)
                {
                    quantity -= food;
                    result.Dequeue();
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(max);
            if (result.Count > 0)
            {
                Console.WriteLine("Orders left: " + string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
