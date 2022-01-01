using System;

namespace _07.WaterOverflow
{
    class Program
    {
        const int capacity = 255;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int amount = 0;
            for (int i = 0; i < n; i++)
            {
                int pour = int.Parse(Console.ReadLine());
                bool isFull = amount + pour > capacity;
                if (isFull)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                amount += pour;
            }
            Console.WriteLine(amount);
        }
    }
}
