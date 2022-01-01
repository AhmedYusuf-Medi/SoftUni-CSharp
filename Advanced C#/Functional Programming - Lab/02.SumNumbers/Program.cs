using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(el =>
                {
                    int result = Convert.ToInt32(el);
                    return result;
                }
                ).ToList();

            Console.WriteLine(nums.Count);
            Console.WriteLine(nums.Sum());
        }
    }
}
 