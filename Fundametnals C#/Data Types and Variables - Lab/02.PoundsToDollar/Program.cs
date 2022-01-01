using System;

namespace _02.PoundsToDollar
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());
            decimal dollar = pound * (decimal)1.31;
            Console.WriteLine($"{dollar:f3}");
        }
    }
}
