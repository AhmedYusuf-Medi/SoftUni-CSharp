using System;
using System.Collections.Generic;

namespace _02.MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> materials = new Dictionary<string, int>();

            string input = String.Empty;

            while ((input = Console.ReadLine())!= "stop")
            {
                string currMat = input;
                int quantity = int.Parse(Console.ReadLine());

                if (materials.ContainsKey(currMat))
                {
                    materials[currMat] += quantity;
                }
                else
                {
                    materials.Add(currMat, quantity);
                }
            }

            foreach (var material in materials)
            {
                Console.WriteLine($"{material.Key} -> {material.Value}");
            }
        }
    }
}
