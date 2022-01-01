using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nsx = Console.ReadLine().
                Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] nums = Console.ReadLine().
                Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            Stack<int> result = new Stack<int>();

            int n = nsx[0];

            for (int i = 0; i < n; i++)
            {
                result.Push(nums[i]);
            }

            int s = nsx[1];
            for (int i = 0; i < s ; i++)
            {
                result.Pop();
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
