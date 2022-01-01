using System;

namespace _12.EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            while (n % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                n = int.Parse(Console.ReadLine());
            }

            if (n < 0)
            {
                n *= -1;
            }

            Console.WriteLine($"This number is: {n}");
        }
    }
}
