using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AvarageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!studentGrades.ContainsKey(name))
                {
                    studentGrades.Add(name, new List<decimal>());
                }
                studentGrades[name].Add(grade);
            }

            foreach (var stuudent in studentGrades)
            {
                Console.WriteLine($"{stuudent.Key} -> {string.Join(" ",stuudent.Value):f2} (avg: {stuudent.Value.Average():f2})");
            }
        }
    }
}
