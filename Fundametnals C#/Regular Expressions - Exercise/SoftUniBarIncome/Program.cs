using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            double total = 0;

            string input = String.Empty;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match match = Regex.Match(input, pattern);
                    string customer = match.Groups["customer"].Value;
                    string product = match.Groups["product"].Value;
                    int quantity = int.Parse(match.Groups["quantity"].Value);
                    double price = double.Parse(match.Groups["price"].Value);
                    double money = price * quantity;
                    Console.WriteLine($"{customer}: {product} - {money:F2}");
                    total += money;
                }
            }
            Console.WriteLine($"Total income: {total:F2}");
        }
    }
}
