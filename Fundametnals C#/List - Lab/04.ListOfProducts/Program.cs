using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>(n);
            for (int i = 0; i < n; i++)
            {
                string currProduct = Console.ReadLine();
                products.Add(currProduct);
            }
            products.Sort();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.{products[i]}");
            }
                                    
        }
    }
}
