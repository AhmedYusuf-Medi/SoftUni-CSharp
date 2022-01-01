using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                                   .Split()
                                   .Select(double.Parse)
                                   .ToList();

            int lenght = numbers.Count / 2;

            for (int i = 0; i < lenght; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}
