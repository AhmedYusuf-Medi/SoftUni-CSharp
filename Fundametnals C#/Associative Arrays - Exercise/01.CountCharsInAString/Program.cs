using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArraysExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> occurences = new Dictionary<char, int>();

            foreach (var letter in input)
            {
                if (letter != ' ')
                {
                    if (!occurences.ContainsKey(letter))
                    {
                        occurences.Add(letter, 1);
                    }
                    else
                    {
                        occurences[letter]++;
                    }
                }    
            }
            foreach (var letter in occurences)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
      
    }
}
