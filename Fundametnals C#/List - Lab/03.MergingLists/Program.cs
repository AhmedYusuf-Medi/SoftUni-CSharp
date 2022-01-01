using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> first = Console.ReadLine()
                                 .Split()
                                 .Select(double.Parse)
                                 .ToList();
            List<double> second = Console.ReadLine()
                                 .Split()
                                 .Select(double.Parse)
                                 .ToList();
            
            List<double> result = new List<double>();
            for (int i = 0; i < Math.Min(first.Count,second.Count) ; i++)
            {
                result.Add(first[i]);
                result.Add(second[i]);
            }
            for (int i = Math.Min(first.Count, second.Count); i < Math.Max(first.Count,second.Count); i++)
            {
                if (i >= first.Count)
                {
                    result.Add(second[i]);
                }
                else
                {
                    result.Add(first[i]);
                }
            }
            Console.WriteLine(string.Join(" ",result));

        }
    }
}
