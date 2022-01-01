using System;
using System.Reflection.Metadata.Ecma335;

namespace _05.Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            switch (product)
            {
                case "coffee":
                    Coffe(quantity);
                    break;
                case "water":
                    Water(quantity);
                    break;
                case "snacks":
                    Snacks(quantity);
                    break;
                case "coke":
                    Coke(quantity);
                    break;
            }
        }
        static void Coffe(int quantity, double price = 1.5)
        {
            Console.WriteLine($"{quantity*price:f2}");
        }
        static void Water(int quantity, double price = 1.00)
        {
            Console.WriteLine($"{quantity * price:f2}");
        }
        static void Coke(int quantity, double price = 1.40)
        {
            Console.WriteLine($"{quantity * price:f2}");
        }
        static void Snacks(int quantity, double price = 2.00)
        {
            Console.WriteLine($"{quantity * price:f2}");
        }

    }
}
