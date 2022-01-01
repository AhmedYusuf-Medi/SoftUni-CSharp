using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.VaporWinterSale
{
    class Program
    {
        static void Main(string[] args)
        {
            //Games that don't have DLC
            Dictionary<string, double> gamesWithoutDLC = new Dictionary<string, double>();

            //Games with DLC
            Dictionary<string, string> gamesWithDLC = new Dictionary<string, string>();

            //Reading a string that we later gonna split
            string input = Console.ReadLine();

            //Spliting the input so we can get our games with price and repeats with dlc
            string[] gamesInformation = input.Split(", ");

            //Looping trough all 
            for (int i = 0; i < gamesInformation.Length; i++)
            {
                //Taking the curr game
                string[] gameArg = gamesInformation[i].Split(new char[]{ '-', ':'});

                //Game argumanetations
                string gameName = gameArg[0];
                string dlcOrPrice = gameArg[1];

                //if we dont have registered game into dictonary we are doing it.
                if (!gamesWithoutDLC.ContainsKey(gameName))
                {
                    gamesWithoutDLC[gameName] = double.Parse(dlcOrPrice);
                }

                //If we already have the game , we are adding to price 20% and add the game to 
                //the second dictionary with dlc
                else
                {
                    if (gamesWithoutDLC.ContainsKey(gameName))
                    {
                        gamesWithoutDLC[gameName] += gamesWithoutDLC[gameName] * 0.2;
                        gamesWithDLC.Add(gameName, dlcOrPrice);
                    }
                }
            }

            //Ordering them by their price
            foreach (var gameWithoutDLC in gamesWithoutDLC.OrderBy(g => g.Value))
            {
                //Printing the games with dlc
                foreach (var gameWithDLC in gamesWithDLC)
                {
                    if (gameWithoutDLC.Key == gameWithDLC.Key)
                    {
                        //if the game has dlc we lowering the price with 50%
                        double price = gameWithoutDLC.Value * 0.5;

                        Console.WriteLine($"{gameWithoutDLC.Key} - {gameWithDLC.Value} - {price:F2}");

                        //Removing the game that we printed
                        gamesWithoutDLC.Remove(gameWithoutDLC.Key);
                    }
                }
            }


            //Printing games withouth dlc
            foreach (var game in gamesWithoutDLC.OrderByDescending(g => g.Value))
            {
                //1 - 0.2 = 0.8 doing if we don't have dlc we are lowering the price with 20%
                double price = game.Value * 0.8;

                Console.WriteLine($"{game.Key} - {price:F2}");
            }
        }
    }
}
