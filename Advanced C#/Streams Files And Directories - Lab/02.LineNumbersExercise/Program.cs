using System;
using System.IO;
using System.Linq;

namespace _02.LineNumbersExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("../../../input.txt");

            string[] newLines = new string[lines.Length];
;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                //Count Letters
                int countLetters = CountingLetters(line);
                //Count makrs
                int countMarks =CountingMarks(line);


                newLines[i] = $"Line {i} {line} ({countLetters})({countMarks})";
            }

            File.WriteAllLines("../../../output.txt", newLines);
        }

        private static int CountingMarks(string line)
        {
            int count = 0;

            char[] symbols = { '-', ',', '.', '!', '?', '\'' };

            for (int i = 0; i < line.Length; i++)
            {

                char currSymbol = line[i];



                if (symbols.Contains(currSymbol))
                {
                    count++;
                }
            }
            return count;
        }

        static int CountingLetters(string line)
        {
            int count = 0;

            for (int j = 0; j < line.Length; j++)
            {
                char currSymbol = line[j];
                if (Char.IsLetter(currSymbol))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
