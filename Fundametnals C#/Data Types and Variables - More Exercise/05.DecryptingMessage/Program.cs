using System;

namespace _05.DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int loops = int.Parse(Console.ReadLine());
            char currChar;
            int value = 0;

            string message = String.Empty;
            for (int i = 0; i < loops; i++)
            {
                currChar = char.Parse(Console.ReadLine());
                value = currChar + key;

                message +=(char)value;
            }

            Console.WriteLine(message);
        }
    }
}
