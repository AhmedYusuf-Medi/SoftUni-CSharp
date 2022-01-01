using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> materials = new Dictionary<string, int>();
            Dictionary<string, int> junks = new Dictionary<string, int>();

            materials["shards"] = 0;
            materials["fragments"] = 0;
            materials["motes"] = 0;

            bool noItem = true;
            //bool hasToBreak = false;
            while (noItem)
            {
                string[] text = Console.ReadLine().Split();

                for (int i = 0; i < text.Length; i+=2)
                {
                    int quantity = int.Parse(text[i]);
                    string material = text[i + 1].ToLower();

                    if (material == "shards" || material =="fragments"||material == "motes")
                    {
                        materials[material] += quantity;

                        if (materials[material] >= 250)
                        {
                            materials[material] -= 250;
                            noItem = false;
                            switch (material)
                            {
                                case "shard":
                                    Console.WriteLine("Shadowmourne obtained!");
                                    break;
                                case "fragments":
                                    Console.WriteLine("Valanyr obtained!");
                                    break;
                                case "motes":
                                    Console.WriteLine("Dragonwrath obtained!");
                                    break;
                                default:
                                    break;
                            }
                           // hasToBreak = true;
                              break;
                        }
                    }
                    else
                    {
                        if (junks.ContainsKey(material))
                        {
                            junks[material] += quantity;
                        }
                        else
                        {
                            junks.Add(material, quantity);
                        }
                    }
                }
               // if (hasoBreak)
               // {
                 //   break;
               // }
            }

            Dictionary<string, int> sortedMaterials = materials.OrderByDescending(v => v.Value)
                .ThenBy(k => k.Key).ToDictionary(a => a.Key , a=> a.Value);
            foreach (var item in sortedMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Dictionary<string, int> sortedJunks = junks.OrderBy(k => k.Key)
                .ToDictionary(a => a.Key, a => a.Value);
            foreach (var item in sortedJunks)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
