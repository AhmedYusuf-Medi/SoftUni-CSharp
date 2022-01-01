using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                string color = input[0];
                string[] clothes = input[1].Split(',').ToArray();

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());
                }
                for (int j = 0; j < clothes.Length; j++)
                {
                    if (!wardrobe[color].ContainsKey(clothes[j]))
                    {
                        wardrobe[color].Add(clothes[j], 0);
                    }
                        wardrobe[color][clothes[j]]++;
                }
            }

            string clothe = Console.ReadLine();

            foreach (var item in wardrobe)
            {
                Console.WriteLine(item.Key +"clothes:");
                foreach (var itemValue in item.Value)
                {
                    string combo = item.Key + " " + itemValue.Key;
                    if (combo == clothe)
                    {
                        Console.WriteLine($"* {itemValue.Key} - {itemValue.Value}(found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {itemValue.Key} - {itemValue.Value}");
                    }
                }
            }
        }
    }
}
