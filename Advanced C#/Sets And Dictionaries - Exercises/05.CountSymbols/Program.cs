using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> symbols = new Dictionary<char, int>();

            string input = Console.ReadLine();


            for (int i = 0; i < input.Length;i++)
            {
                char currSymbol = input[i];
                if (!symbols.ContainsKey(currSymbol))
                {
                    symbols.Add(currSymbol, 1);
                }
                else
                {
                    symbols[currSymbol]++;
                }
            }

            foreach (var symbol in symbols.OrderBy(s =>s.Key))
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
