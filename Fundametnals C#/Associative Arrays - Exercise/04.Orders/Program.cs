using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            string input = String.Empty;

            while ((input= Console.ReadLine())!= "buy")
            {
                string[] arg = input.Split();
                string name = arg[0];
                double price = double.Parse(arg[1]);
                int quantiti = int.Parse(arg[2]);
                List<double> total = new List<double>{ price, quantiti };

                if (products.ContainsKey(name))
                {
                    products[name][0] = price;
                    products[name][1] = products[name][1] + quantiti;
                }
                else
                {
                    products.Add(name, total);
                }
            }
            foreach (var item in products)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
