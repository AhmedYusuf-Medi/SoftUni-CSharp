using System;

namespace _10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokeTarget = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());

            int targetCount = 0;

            double originalValue = pokePower * 0.50;

            while (pokePower >= pokeTarget)
            {
                if (pokePower == originalValue)
                {
                    if (exhaustionFactor > 0)
                    {
                        pokePower = pokePower / exhaustionFactor;

                        if (pokePower < pokeTarget)
                        {
                            break;
                        }
                    }                
                }
                pokePower -= pokeTarget;
                targetCount++;
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(targetCount);
        }
    }
}
