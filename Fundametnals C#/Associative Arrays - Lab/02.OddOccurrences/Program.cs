using System;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> counts = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string wordInUpper = word.ToLower();

                if (counts.ContainsKey(wordInUpper))
                {
                    counts[wordInUpper]++;
                }
                else
                {
                    counts.Add(wordInUpper, 1);
                }
            }

            foreach (var count in counts)
            {
                if (count.Value % 2 != 0)
                {
                    Console.Write(count.Key + " ");
                }
                else
                {
                    continue;
                }
            }
        }
    }
}