using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
         public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> family = new List<Person>();

            GetFamilyMembers(n, family);

            family = family.Where(m => m.Age > 30).OrderBy(m => m.Name).ToList();
            Print(family);

        }

        private static void Print(List<Person> family)
        {
            foreach (var member in family)
            {
                Console.WriteLine(member.Name + " - " + member.Age);
            }
        }

        private static void GetFamilyMembers(int n, List<Person> family)
        {
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                family.Add(person);
            }
        }
    }
}
