using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int start = input[0];
            int end = input[1];

            string critearia = Console.ReadLine();

            List<int> nums = new List<int>();

            for (int i = start; i <= end; i++)
            {
                nums.Add(i);
            }

            Predicate<int> even = n => n % 2 == 0;
            Predicate<int> odd = n => n % 2 == 1;
            

            if (critearia == "even")
            {
                nums = nums.Where(n => even(n)).ToList();
            }
            else
            {
                nums = nums.Where(n => odd(n)).ToList();
            }

            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
