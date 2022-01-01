using System;

namespace _01.SignNum
{
    class Program
    {
        static void Main(string[] args)
        {
            InputSign(int.Parse(Console.ReadLine()));
        }
        static void InputSign(int num)
        {
            if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }
            else if (num > 0)
            {
                Console.WriteLine($"The number {num} is positvie.");
            }
            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
