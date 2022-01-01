using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, List<string>> courses = new Dictionary<string, List<string>>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] arg = input.Split(" : ");
                string name = arg[0];
                List<string> student = new List<string> { arg[1]};

                if (courses.ContainsKey(name))
                {
                    courses[name].Add(arg[1]);
                }
                else
                {
                    courses.Add(name, student);
                }
            }

            foreach (var course in courses.OrderByDescending(x=>x.Value.Count))
            {
                int count = course.Value.Count;
                Console.WriteLine($"{course.Key}: {count}");
                foreach (var name in course.Value.OrderBy(x=>x))
                {
                    Console.WriteLine($"-- {name}");
                }
                
            }
        }
    }
}
