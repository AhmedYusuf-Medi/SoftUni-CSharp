using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string text = String.Empty;

            Func<int,int> add = n => n + 1;
            Func<int,int> multiply = n => n * 2;
            Func<int,int> subtract = n => n -  1;
            Action<int[]> print = x => Console.WriteLine(string.Join(" ",x));
          

            while ((text = Console.ReadLine()) != "end")
            {
                switch (text)
                {
                    case "add":
                        input = input.Select(n => add(n)).ToList();
                        break;
                    case "multiply":
                        input = input.Select(n => multiply(n)).ToList();
                        break;
                    case "subtract":
                        input = input.Select(n => subtract(n)).ToList();
                        break;
                    case "print":
                        print(input.ToArray());
                        break;
                    default:

                        break;
                }
            }
        }
    }
}
