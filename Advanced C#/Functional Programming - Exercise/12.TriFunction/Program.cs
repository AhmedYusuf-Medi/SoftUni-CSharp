using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int> asciSum = p => p.Select(c =>  (int)c).Sum();

            string name = GetName(names, n, asciSum);

            Console.WriteLine(name);
        }
        static string GetName(List<string> names, int n, Func<string, int> asciSum)
        {
            string res = null;

            foreach (string name in names)
            {
                if (asciSum(name) >=n)
                {
                    res = name;
                }
            }
            return res;
        }
    }
}
