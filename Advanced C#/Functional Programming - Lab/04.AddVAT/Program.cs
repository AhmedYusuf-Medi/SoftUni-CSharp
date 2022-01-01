using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AddVAT
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(p =>
                {
                    double num = double.Parse(p);
                    return num * 1.2;
                }
                )
                .ToList()
                .ForEach(p => Console.WriteLine($"{p:f2}"));
        }
    }
}
