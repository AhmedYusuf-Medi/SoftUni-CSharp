using System;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int explosiveStrength = 0;

            for (int i = 0; i < input.Length - 1; i++)
            {
                char currChar = input[i];

                if (currChar == '>')
                {
                    explosiveStrength += (int)Char.GetNumericValue(input[i + 1]);
                }
                else if (explosiveStrength > 0)
                {
                    input = input.Remove(i, 1);
                    explosiveStrength--;
                    i--;
                }
            }

            Console.WriteLine(input);
        }
    }
}
