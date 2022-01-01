using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> chemicals = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                for (int j = 0; j < input.Length; j++)
                {
                    if (!chemicals.Contains(input[j]))
                    {
                        chemicals.Add(input[j]);
                    }
                }
            }

            var orderedChemicals = chemicals.OrderBy(x=>x);

            Console.WriteLine(string.Join(" ",orderedChemicals));
        }
    }
}