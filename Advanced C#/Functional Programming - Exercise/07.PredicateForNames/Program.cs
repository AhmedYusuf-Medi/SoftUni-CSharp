using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtCriteria = int.Parse(Console.ReadLine());

            List<string> names = Console.ReadLine().Split().ToList();

            names = names.Where(n => n.Length <= lenghtCriteria).ToList();

            Console.WriteLine(string.Join(Environment.NewLine, names));


            
        }
    }
}
