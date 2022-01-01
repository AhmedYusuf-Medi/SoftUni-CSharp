using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> products =
                new Dictionary<string, Dictionary<string, double>>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "Revision")
            {
                string[] arg = input.Split(", ");
                string shop = arg[0];
                string product = arg[1];
                double price = double.Parse(arg[2]);

                if (!products.ContainsKey(shop))
                {
                    products.Add(shop, new Dictionary<string, double>());
                }
                products[shop].Add(product, price);
            }

            products = products.OrderBy(p => p.Key).ToDictionary(k=>k.Key ,v => v.Value);

            foreach (var product in products)
            {
                Console.WriteLine(product.Key +"->");
                foreach (var item in product.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
