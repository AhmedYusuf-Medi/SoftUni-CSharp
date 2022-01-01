using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Dictionary<double, int> valuesCount = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!valuesCount.ContainsKey(numbers[i]))
                {
                    valuesCount.Add(numbers[i], 1);
                }
                else
                {
                    valuesCount[numbers[i]]++;
                }
            }

            foreach (var value in valuesCount)
            {
                Console.WriteLine($"{value.Key} - {value.Value} times");
            }
        }
    }
}
