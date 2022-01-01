using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            if (nums.Count < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                int sum = nums.Sum();
                double avarage = sum / nums.Count;


                List<int> greater = nums.FindAll(x => x > avarage);

                if (greater.Count > 5)
                {
                    int newSum = greater.Sum();
                    double average = newSum / greater.Count;
                    var result = greater.OrderByDescending(x => x).Where(x => x > average).Take(5).ToArray();
                    Console.WriteLine(string.Join(" ", result));
                }
                else
                {
                    greater = greater.OrderByDescending(c => c).ToList();

                    Console.WriteLine(string.Join(" ", greater));
                }
            }
        }
    }
}
