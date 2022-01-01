using System;
using System.Linq;

namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int shots = 0;

            string input = Console.ReadLine();

            while (input != "End")
            {
                shots++;

                int currI = int.Parse(input);

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[currI] <= nums[i])
                    {
                        nums[i] = -1;
                    }
                    else
                    {
                        nums[i] -= nums[currI];
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {shots}",string.Join(" ",nums));

        }
    }
}
