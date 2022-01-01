using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int[]>> dragonArmy = new Dictionary<string, Dictionary<string, int[]>>();

            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] parts = Console.ReadLine().Split();
                string type = parts[0];
                string name = parts[1];
                string damageAsStr = parts[2];
                string healthAsStr = parts[3];
                string armorAsStr = parts[4];

                if (damageAsStr == "null")
                {
                    damageAsStr = "45";
                }

                if (healthAsStr == "null")
                {
                    healthAsStr = "250";
                }

                if (armorAsStr == "null")
                {
                    armorAsStr = "10";
                }

                int damage = int.Parse(damageAsStr);
                int health = int.Parse(healthAsStr);
                int armor = int.Parse(armorAsStr);


                if (!dragonArmy.ContainsKey(type))
                {
                    dragonArmy.Add(type, new Dictionary<string, int[]>());
                }

                if (!dragonArmy[type].ContainsKey(name))
                {
                    dragonArmy[type].Add(name, new int[3]);
                }

                dragonArmy[type][name][0] = damage;
                dragonArmy[type][name][1] = health;
                dragonArmy[type][name][2] = armor;

            }

            StringBuilder output = new StringBuilder();
            foreach (var dragonType in dragonArmy)
            {
                double averageDmg = 0;
                double averageHealth = 0;
                double averageArmor = 0;

                int counter = 0;
                foreach (var stats in dragonType.Value)
                {
                    averageDmg += stats.Value[0];
                    averageHealth += stats.Value[1];
                    averageArmor += stats.Value[2];
                    counter++;
                }

                output.AppendLine($"{dragonType.Key}::({averageDmg / counter:F2}/{averageHealth / counter:F2}/{averageArmor / counter:F2})");

                foreach (var dragon in dragonType.Value.OrderBy(d => d.Key))
                {
                    output.AppendLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }

            Console.WriteLine(output.ToString());
        }
    }
}
