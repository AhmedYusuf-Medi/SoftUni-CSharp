using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();

            names = names.Select(n => $"Sir {n}").ToArray();

            Action<string[]> printNamesWithTittle = n =>
            Console.WriteLine(string.Join(Environment.NewLine, n));

            printNamesWithTittle(names);
        }
    }
}
