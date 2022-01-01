using System;
using System.Collections.Generic;

namespace _05.FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,int> peoples = Inputpeoples();

            string olderOrYounger = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<int, bool> tester = Tester(olderOrYounger, age);
            Action<KeyValuePair<string, int>> printer = Format(format);

            InvokePrinter(peoples, tester, printer);
        }

        private static void InvokePrinter(
            Dictionary<string, int> peoples,
            Func<int, bool> tester,
            Action<KeyValuePair<string, int>> printer)
        {
            foreach (var people in peoples)
            {
                if (tester(people.Value))
                {
                    printer(people);
                }
            }
        }

        private static Action<KeyValuePair<string, int>> Format(string format)
        {
            switch (format)
            {
                case "name age":
                    return kvp => Console.WriteLine($"{kvp.Key} - {kvp.Value}");
                case "name":
                    return kvp => Console.WriteLine($"{kvp.Key}");
                case "age":
                    return kvp => Console.WriteLine($"{kvp.Value}");
                default:
                    return null;
            }
        }

        private static Func<int, bool> Tester(string olderOrYounger, int age)
        {
            switch (olderOrYounger)
            {
                case "older":
                    return n => n >= age;
                case "younger":
                    return n => n < age;
                default:
                    return null;
            }
        }

        private static Dictionary<string, int> Inputpeoples()
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var peoples = new Dictionary<string, int>(numberOfLines);

            for (int i = 0; i < numberOfLines; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

                peoples[input[0]] = int.Parse(input[1]);
            }

            return peoples;
        }
    }
}
