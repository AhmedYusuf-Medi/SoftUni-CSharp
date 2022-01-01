using System;
using System.Collections.Generic;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> sequneces = new Dictionary<int, int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int currNumber = int.Parse(Console.ReadLine());

                if (!sequneces.ContainsKey(currNumber))
                {
                    sequneces.Add(currNumber, 1);
                }
                else
                {
                    sequneces[currNumber]++;
                }
            }

            foreach (var num in sequneces)
            {
                if (num.Value % 2 == 0)
                {
                    Console.WriteLine(num.Key);
                    break;
                }
            }

        }
    }
}
