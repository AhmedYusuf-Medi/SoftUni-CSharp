using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split();

            string first = text[0];
            string second = text[1];

            string longest = first;
            string shortest = second;

            if (longest.Length < shortest.Length)
            {
                shortest = first;
                longest = second;
            }

            int total = Multiplier(longest, shortest);
            Console.WriteLine(total);

        }
        public static int Multiplier(string longest, string shortest)
        {
            var sum = 0;
            for (int i = 0; i < shortest.Length; i++)
            {
                var mupltiply = longest[i] * shortest[i];
                sum += mupltiply;
            }
            for (int i = shortest.Length; i < longest.Length; i++)
            {
                sum += longest[i];
            }
            return sum;
        }

    }
}
