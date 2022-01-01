using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DrumSet
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal profits = decimal.Parse(Console.ReadLine());

            List<int> drumSetOG = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> drumSetsCopy = drumSetOG.ToList();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < drumSetsCopy.Count; i++)
                {
                    drumSetsCopy[i] -= hitPower;

                    if (drumSetsCopy[i] <= 0)
                    {
                        if (profits - (drumSetOG[i] * 3) >= 0)
                        {
                            drumSetsCopy[i] = drumSetOG[i];
                            profits -= drumSetOG[i] * 3;
                        }
                    }
                }

                for (int i = 0; i < drumSetOG.Count; i++)
                {
                    if (drumSetsCopy[i] <= 0)
                    {
                        drumSetOG.RemoveAt(i);
                        drumSetsCopy.RemoveAt(i);
                    }
                }
            }

            Console.WriteLine(string.Join(' ',drumSetsCopy));

            Console.WriteLine($"Gabsy has {profits:f2}lv.");

        }
    }
}
