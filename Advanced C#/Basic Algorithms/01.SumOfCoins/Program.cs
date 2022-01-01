using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumOfCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            //Coins: .... (seperated with ", ")
            string[] inputCoins = Console.ReadLine().Split(": ");

            int[] nums = inputCoins[1].Split(", ").Select(int.Parse).ToArray();
            nums = nums.OrderByDescending(c => c).ToArray();
            //Sum: ... 
            string[] inputTarget = Console.ReadLine().Split(": ");
            int target = int.Parse(inputTarget[1]);

            try
            {
                var selectedCoins = ChooseCoins(nums, target);

                Console.WriteLine($"Number of coins to take: {selectedCoins.Values.Sum()}");
                foreach (var coin in selectedCoins)
                {
                    Console.WriteLine($"{coin.Value} coin(s) with value {coin.Key}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static Dictionary<int,int> ChooseCoins(int[] coins,int target)
        {
            var chosenCoins = new Dictionary<int, int>();
            int currentSum = 0;
            int coinIndex = 0;

            while (currentSum != target && coinIndex < coins.Length)
            {
                int currentCoinValue = coins[coinIndex];
                int remainingSum = target - currentSum;
                int numberOfCoinToTake = remainingSum / currentCoinValue;

                if (numberOfCoinToTake > 0)
                {
                    chosenCoins[currentCoinValue] = numberOfCoinToTake;

                    currentSum += currentCoinValue * numberOfCoinToTake;
                }

                coinIndex++;

            }

            if (currentSum == target)
            {
                return chosenCoins;
            }
            else
            {
                throw new InvalidOperationException("Error");
            }
        }
    }
}
