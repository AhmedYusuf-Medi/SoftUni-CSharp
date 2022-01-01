using System;
using System.Collections.Generic;

namespace _03.SimpeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            Stack<string> stackedInput = new Stack<string>();

            for (int i = input.Length- 1; i >= 0; i--)
            {
                stackedInput.Push(input[i]);
            }

            while (stackedInput.Count > 1)
            {
                int first = int.Parse(stackedInput.Pop());
                char sign = char.Parse(stackedInput.Pop());
                int sec = int.Parse(stackedInput.Pop());
                if (sign == '+')
                {
                    stackedInput.Push((first + sec).ToString());
                }
                else if(sign == '-')
                {
                    stackedInput.Push((first - sec).ToString());
                }
            }
            Console.WriteLine(stackedInput.Pop());
        }
    }
}
