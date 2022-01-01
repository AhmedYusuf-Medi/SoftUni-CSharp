using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> reverse = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                reverse.Push(input[i]);
            }
            while (reverse.Any())
            {
                Console.Write(reverse.Pop());
            }

            Console.WriteLine();
        }
    }
}
