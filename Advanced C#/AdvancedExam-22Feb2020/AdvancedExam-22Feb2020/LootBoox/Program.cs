using System;
using System.Collections.Generic;
using System.Linq;

namespace LootBoox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstBox = new Queue<int>(Console.ReadLine().
               Split(' ', StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse)
              );

            Stack<int> secBox = new Stack<int>(Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                );

            int value = 0;

            while (firstBox.Count > 0 && secBox.Count > 0)
            {
                int firstInt = firstBox.Peek();
                int secInt = secBox.Pop();

                int sum = firstInt + secInt;
                if (sum % 2 == 0)
                {
                    value += sum;
                    firstBox.Dequeue();
                }
                else
                {
                    firstBox.Enqueue(secInt);
                }
            }

            if (firstBox.Count - 1 < 0)
            {
                Console.WriteLine("First lootbox is empty");
            }
            if (secBox.Count - 1 < 0)
            {
                Console.WriteLine("Second lootbox is empty");
            }

            if (value >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {value}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {value}");
            }
        }
    }
}
