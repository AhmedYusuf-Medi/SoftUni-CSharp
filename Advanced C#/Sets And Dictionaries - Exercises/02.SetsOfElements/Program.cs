using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int n = numbers[0];
            int m = numbers[1];

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secSet = new HashSet<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                firstSet.Add(number);
            }

            for (int i = 0; i < m; i++)
            {
                int number = int.Parse(Console.ReadLine());

                secSet.Add(number);
            }

            int[] result = firstSet.Intersect(secSet).ToArray();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
