using System;
using System.Collections.Generic;

namespace DefiningClasses
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family members = new Family();

            GetFamilyMembers(n, members);

            Person oldest = members.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");

        }

        private static void GetFamilyMembers(int n, Family members)
        {
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                members.AddMember(person);
            }
        }
    }
}
