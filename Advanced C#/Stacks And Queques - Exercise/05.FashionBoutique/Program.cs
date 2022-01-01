using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().
                        Split(" ", StringSplitOptions.RemoveEmptyEntries).
                        Select(int.Parse).ToArray();
            Stack<int> clothes = new Stack<int>(nums);

            int capacity = int.Parse(Console.ReadLine());

            int racks = 1;
            int sum = 0;

            while (clothes.Any())
            {
                var currClothe = clothes.Pop();
                sum += currClothe;
                if (capacity >= sum)
                {
                    continue;
                }
                else
                {
                    racks++;
                    sum =0;
                    sum += currClothe;
                }
            }
            Console.WriteLine(racks);
        }
    }
}
