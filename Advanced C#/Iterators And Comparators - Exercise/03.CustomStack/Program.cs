using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.CustomStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack<int> items = new Stack<int>();

            string comand;

            while ((comand = Console.ReadLine()) != "END")
            {
                string[] tokens = comand
                    .Split(new string[] { " ", ", " }, StringSplitOptions.RemoveEmptyEntries);

                string currComand = tokens[0];

                if (currComand == "Push")
                {
                    List<int> numbers = tokens.Skip(1).Select(int.Parse).ToList();

                    foreach (var n in numbers)
                    {
                        items.Push(n);
                    }
                }
                else if (comand == "Pop")
                {
                    try
                    {
                        items.Pop();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
            }

            foreach (var i in items)
            {
                Console.WriteLine(i);
            }
            foreach (var i in items)
            {
                Console.WriteLine(i);
            }
        }
    }
}
