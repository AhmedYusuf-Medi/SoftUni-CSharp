using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] arg = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string firstName = arg[0];
                string lastName = arg[1];
                int age = int.Parse(arg[2]);

                Person person = new Person(firstName, lastName, age);
                persons.Add(person);
            }

            persons.OrderBy(p => p.FistName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p));
        }
    }
}
