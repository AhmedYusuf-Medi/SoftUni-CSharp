using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        const int datureBombs = 40;
        const int cherryBombs = 60;
        const int smokeDecoyBombs = 120;
        static void Main(string[] args)
        {
            int[] bombQueue = Console.ReadLine()
                 .Split(",", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int[] bombStack = Console.ReadLine()
                .Split(",", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            Queue<int> bombEfects = new Queue<int>(bombQueue);

            Stack<int> bombCasing = new Stack<int>(bombStack);

            Dictionary<string, int> bombs = new Dictionary<string, int>();
            bombs.Add("Cherry Bombs", 0);
            bombs.Add("Datura Bombs", 0);
            bombs.Add("Smoke Decoy Bombs", 0);
            bombs = bombs.OrderBy(b => b.Key).ToDictionary(b => b.Key, b => b.Value);

            int cheryCounter = 0;
            int datureCounter = 0;
            int smokeCounter = 0;

            bool allAreCompleted = false;

            //bool isComlpeted = cheryCounter >= 3 && datureCounter >= 3 && smokeCounter >= 3;

            while (bombEfects.Count > 0 && bombCasing.Count > 0)
            {
                int bombEfect = bombEfects.Peek();
                int bombCase = bombCasing.Peek();

                int sum = bombEfect + bombCase;


                switch (sum)
                {
                    case datureBombs:
                        datureCounter++;
                        bombs["Datura Bombs"]++;
                        bombCasing.Pop();
                        bombEfects.Dequeue();
                        break;
                    case cherryBombs:
                        cheryCounter++;
                        bombs["Cherry Bombs"]++;
                        bombCasing.Pop();
                        bombEfects.Dequeue();
                        break;
                    case smokeDecoyBombs:
                        smokeCounter++;
                        bombs["Smoke Decoy Bombs"]++;
                        bombCasing.Pop();
                        bombEfects.Dequeue();
                        break;
                    default:
                        bombCasing.Pop();
                        bombCasing.Push(bombCase - 5);
                        break;
                }
                if (datureCounter >= 3 && cheryCounter >= 3 && smokeCounter >= 3)
                {
                    allAreCompleted = true;
                    break;
                }
            }

            if (allAreCompleted)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEfects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else if(bombEfects.Count > 0)
            {

                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEfects)}");
            }

            if (bombCasing.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else if(bombCasing.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");

            }

            foreach (var bomb in bombs)
            {
                Console.WriteLine($"{bomb.Key}: {bomb.Value}");
            }
        }
    }
}
