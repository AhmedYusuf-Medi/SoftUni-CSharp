using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().
                        Split().
                        Select(int.Parse)
                        .ToArray();

            Func<int[], int> minFunction = n =>
            {
                return GetMin(nums);
            }
            ;

            Console.WriteLine(minFunction(nums));

             
        }

        private static int GetMin(int[] nums)
        {
            int min = int.MaxValue;

            foreach (var num in nums)
            {
                if (num < min)
                {
                    min = num;
                }
            }

            return min;
        }
    }
}
  