using System;
using System.Text;

namespace _05.DiggitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder characters = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (char.IsDigit(symbol))
                {
                    digits.Append(symbol);
                }
                if (char.IsLetter(symbol))
                {
                    letters.Append(symbol);
                }
                if (!char.IsLetterOrDigit(symbol))
                {
                    characters.Append(symbol);
                }

            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(characters);
        }
    }
}
