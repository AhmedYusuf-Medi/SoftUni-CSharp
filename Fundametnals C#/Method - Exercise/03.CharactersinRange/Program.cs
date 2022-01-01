using System;

namespace _03.CharactersinRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            Beetween(first, second);
        }

        private static void Beetween(char first, char second)
        {
            if (second - first < 0)
            {
                char firstChar = first;
                first = second;
                second = firstChar;
            }

            for (int i = first+1; i < second; i++)
            {
                Console.Write((char)i +" ");
            }
        }
    }
}
