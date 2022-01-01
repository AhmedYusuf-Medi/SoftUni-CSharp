using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string input = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(input, patern);

            foreach (Match matches in matchedNames)
            {
                Console.Write(matches.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
