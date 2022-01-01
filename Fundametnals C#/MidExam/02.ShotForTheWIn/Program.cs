using System;
using System.Linq;

namespace _02.ShotForTheWIn
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int shots = 0;

            string input = Console.ReadLine();

            while (input != "End")
            {

                int currI = int.Parse(input);

                if (currI < 0 || currI >= nums.Length || nums[currI] == -1)
                {
                    input = Console.ReadLine();

                    continue;
                }

                int shot = nums[currI];
                nums[currI] = -1;
                shots++;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == -1)
                    {
                        continue;
                    }
                    if (nums[i] > shot)
                    {
                        nums[i] -= shot;
                    }
                    else
                    {
                        nums[i] += shot;
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {shots} -> {string.Join(" ", nums)}");
        }
    }
}
