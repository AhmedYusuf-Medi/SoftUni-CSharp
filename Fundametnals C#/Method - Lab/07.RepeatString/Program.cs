using System;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Repeat(text, n);
        }
        static void Repeat(string text, int n)
        {
            string result = string.Empty;
            for (int i = 0; i < n; i++)
            {
                Console.Write(text);
            }
        }
    }
}
