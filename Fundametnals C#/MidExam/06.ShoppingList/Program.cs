using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().
                Split("!",StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();

            while (input != "Go Shopping!")
            {
                string[] text = input.Split().ToArray();
                string comand = text[0];
                string firstItem = text[1];

                bool exist = items.Contains(firstItem);

                switch (comand)
                        {
                            case "Urgent":
                        if (!exist)
                        {
                            items.Insert(0, firstItem);
                        }
                                break;
                            case "Unnecessary":
                                items.Remove(firstItem);
                                break;
                            case "Correct":
                            string newItem = text[2];
                        
                             if (exist)
                            {
                            int index = items.FindIndex(i => i == firstItem);
                            items[index] = newItem;
                            }

                                 break;
                            case "Rearrange":
                        if (exist)
                        {
                            string currentProduct = firstItem;
                            items.Remove(firstItem);
                            items.Add(currentProduct);
                        }
                                 break;
                        }

                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ",items));
        }
    }
}
