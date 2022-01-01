using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            //Dictionary<string, int> peoples = new Dictionary<string, int>();

            string text;

            while ((text = Console.ReadLine()) != "End of list")
            {
                string[] input = text.Split(", ");
                string name = input[0];
                int age = int.Parse(input[1]);

                Person person  = new Person();
                person.Name = name;
                person.Age = age;

                Console.WriteLine($"Name: {person.Name} , Age: {person.Age}");
 
            }

        }
    }
}
