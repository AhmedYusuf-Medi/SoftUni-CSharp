using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Foniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @">>(?<name>[A-Za-z]+)<<(?<price>\d+.?\d*)!(?<quantity>\d+)";
            string input = String.Empty;

            List<string> names = new List<string>();

            double total = 0;

            while ((input =  Console.ReadLine()) != "Purchase")
            {
                MatchCollection matches = Regex.Matches(input, patern);

                foreach (Match mach in matches)
                {
                    string name = mach.Groups["name"].Value;
                    names.Add(name);
                    double price = double.Parse(mach.Groups["price"].Value);
                    double quantity = double.Parse(mach.Groups["quantity"].Value);
                    total += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");
            if (total > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, names));
            }
            Console.WriteLine($"Total money spend: {total:f2}");
        }
    }
}
