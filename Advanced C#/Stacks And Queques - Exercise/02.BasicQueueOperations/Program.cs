using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] nums = Console.ReadLine().
                Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Queue<int> result = new Queue<int>();

            int n = nsx[0];

            for (int i = 0; i < n; i++)
            {
                result.Enqueue(nums[i]);
            }

            int s = nsx[1];
            for (int i = 0; i < s; i++)
            {
                result.Dequeue();
            }
            int count = result.Count;
            int x = nsx[2];

            if (count > 0)
            {
                bool found = result.Contains(x);
                int smallest = result.Min();
                if (found)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(smallest);
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
