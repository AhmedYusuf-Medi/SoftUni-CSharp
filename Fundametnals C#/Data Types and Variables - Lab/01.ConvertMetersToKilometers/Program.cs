using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal km = meters / 1000;

            Console.WriteLine($"{km:f2}");
        }
    }
}
