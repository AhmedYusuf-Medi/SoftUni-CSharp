using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MixedUpLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split(' ').Select(int.Parse)
                .ToList();
            List<int> secondList = Console.ReadLine().Split(' ').Select(int.Parse)
                .ToList();

            List<int> mixedList = new List<int>();

            secondList.Reverse();

            int length = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < length; i++)
            {
                mixedList.Add(firstList[i]);
                mixedList.Add(secondList[i]);
            }

            List<int> constraints = new List<int>();
            if (firstList.Count > secondList.Count)
            {
                constraints.Add(firstList[firstList.Count - 1]);
                constraints.Add(firstList[firstList.Count - 2]);
            }
            else
            {
                constraints.Add(secondList[secondList.Count - 1]);
                constraints.Add(secondList[secondList.Count - 2]);
            }

            constraints = constraints.OrderByDescending(n => n).ToList();
            int firstValidationNumber = constraints[0];
            int secondValidationNumber = constraints[1];

            int biggerConstraint = Math.Max(firstValidationNumber, secondValidationNumber);
            int smallerConstraint = Math.Min(firstValidationNumber, secondValidationNumber);

            mixedList = mixedList.OrderBy(n => n)
                .Where(n => n < biggerConstraint && n > smallerConstraint).ToList();

            Console.WriteLine(string.Join(' ',mixedList));
        }
    }
}
