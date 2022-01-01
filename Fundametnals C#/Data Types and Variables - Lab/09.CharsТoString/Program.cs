using System;

namespace _09.CharsТoString
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = String.Empty;
            for (int i = 0; i < 3; i++)
            {
                char currChar = char.Parse(Console.ReadLine());
                output += currChar;
            }

            Console.WriteLine(output);
        }
    }
}
