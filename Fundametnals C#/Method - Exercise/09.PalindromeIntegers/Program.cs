using System;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = (Console.ReadLine());
            PalindromeIntegers(input);
        }

        private static void PalindromeIntegers(string input)
        {
            while (input !="END")
            {
                string reversedString = string.Empty;
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    char symbol = input[i];
                    reversedString += symbol;
                }
                if (reversedString == input)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                input = Console.ReadLine();
            }
            

        }
    }
}
