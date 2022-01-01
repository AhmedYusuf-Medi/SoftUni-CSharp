using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        const int atleastSpicies = 100;
        const int spiceEaten = 26;
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int totalSpices = 0;
            int dayCount = 0;

            while (input >= atleastSpicies)
            {
                totalSpices += input - spiceEaten;
                dayCount++;
                input -= 10;
            }

            if (totalSpices >= spiceEaten)
            {
                totalSpices -= spiceEaten;
            }

            Console.WriteLine(dayCount);
            Console.WriteLine(totalSpices);
        }
    }
}
