using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split()
                .Select(int.Parse).Reverse().ToList();

            int divisNum = int.Parse(Console.ReadLine());

            nums = nums.Where(n => n % divisNum != 0).ToList();

            Console.WriteLine(string.Join(" ",nums));

          


        }
    }
}
