using System;
using System.Collections.Generic;
using System.Linq;
namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).ToArray();

            Stack<int> nStack = new Stack<int>(numbers);

            string input = String.Empty;

            while ((input=Console.ReadLine().ToLower()) !="end")
            {
                string[] arg = input.Split().ToArray();
                string comand = arg[0].ToLower();
                switch (comand)
                {
                    case "add":
                            for (int i = 1; i < arg.Length; i++)
                            {
                                nStack.Push(int.Parse(arg[i]));
                            }
                        break;
                    case "remove":
                        int remove = int.Parse(arg[1]);
                        if (remove <= nStack.Count)
                        {
                            for (int i = 0; i < remove; i++)
                            {
                                nStack.Pop();
                            }
                        }
                        break;
                    default:
                        break; 
                }
            }
            Console.WriteLine("Sum: "+nStack.Sum());
        } 
    }
}
