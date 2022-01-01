using System;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries);

            decimal totalSum = 0;

            foreach (var word in input)
            {
                char firstCharacter = word[0];
                char lastCharaceter = word.Last();
                if (word.Length >= 3 && char.IsLetter(firstCharacter) && char.IsLetter(lastCharaceter))
                {
                    long number = int.Parse(word.Substring(1, word.Length - 2));

                    decimal sum = 0;

                    if (char.IsUpper(firstCharacter))
                    {
                        int position = word[0] - 'A' + 1;
                        sum += number / (decimal)position;
                    }
                    else
                    {
                        int position = word[0] - 'a' + 1;
                        sum += number * (decimal)position;
                    }

                    if (char.IsUpper(word.Last()))
                    {
                        int position = word.Last() - 'A' + 1;
                        sum -= position;
                    }
                    else
                    {
                        int position = word.Last() - 'a' + 1;
                        sum += position;
                    }

                    totalSum += sum;

                }
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
