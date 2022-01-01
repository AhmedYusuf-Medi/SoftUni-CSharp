using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string moneyReceive = Console.ReadLine();
            double sum = 0;
            while (moneyReceive != "Start")
            {
                double money = double.Parse(moneyReceive);
                if (money == 0.1 ||
                    money == 0.2 ||
                    money == 0.5 ||
                    money == 1 ||
                    money == 2
                    )
                {
                    sum += money;
                }
                else
                {
                    Console.WriteLine($"Cannot accept { money}");
                }
                moneyReceive = Console.ReadLine();
            }
            string product = Console.ReadLine();
            while (product != "End")
            {
                double productPrice = 0;
                switch (product)
                {
                    case "Nuts":
                        productPrice = 2;
                        break;
                    case "Water":
                        productPrice = 0.7;

                        break;
                    case "Crisps":
                        productPrice = 1.5;
                        break;
                    case "Soda":
                        productPrice = 0.8;
                        break;
                    case "Coke":
                        productPrice = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        product = Console.ReadLine();
                        continue;
                }
                if (productPrice <= sum)
                {
                    sum -= productPrice;
                    Console.WriteLine($"Purchased {product.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}

