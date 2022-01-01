using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        public const int breadValue = 25;
        public const int cakeValue = 50;
        public const int pastryValue = 75;
        public const int fruitPie = 100;
        static void Main(string[] args)
        {
            Dictionary<string, int> foods = new Dictionary<string, int>();
            foods = FillFoodsAndOrderThem(foods);

            Queue<int> liquids = new Queue<int>(Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            Stack<int> ingredients = new Stack<int>(Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                int currLiquid = liquids.Dequeue();
                int currIngredient = ingredients.Peek();

                int sum = currIngredient + currLiquid;
                int temp;
                switch (sum)
                {
                    case breadValue:
                        foods["Bread"]++;
                        ingredients.Pop();
                        break;
                    case cakeValue:
                        foods["Cake"]++;
                        ingredients.Pop();
                        break;
                    case pastryValue:
                        foods["Pastry"]++;
                        ingredients.Pop();
                        break;
                    case fruitPie:
                        foods["Fruit Pie"]++;
                        ingredients.Pop();
                        break;
                    default:
                        temp = ingredients.Pop();
                        temp += 3;
                        ingredients.Push(temp);
                        break;
                }
            }

            IsAllFoodsCooked(foods);
            Print(foods, liquids, ingredients);
        }

        private static Dictionary<string, int> FillFoodsAndOrderThem(Dictionary<string, int> foods)
        {
            foods.Add("Bread", 0);
            foods.Add("Cake", 0);
            foods.Add("Pastry", 0);
            foods.Add("Fruit Pie", 0);
            foods = foods.OrderBy(f => f.Key).ToDictionary(k => k.Key, v => v.Value);
            return foods;
        }

        private static void Print(Dictionary<string, int> foods, Queue<int> liquids, Stack<int> ingredients)
        {
            if (liquids.Count == 0 && ingredients.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }
            foreach (var food in foods)
            {
                Console.WriteLine($"{food.Key}: {food.Value}");
            }
        }

        private static void IsAllFoodsCooked(Dictionary<string, int> foods)
        {
            bool isAllProductsCooked = true;
            foreach (var food in foods)
            {
                if (food.Value <= 0)
                {
                    isAllProductsCooked = false;
                }
            }

            if (isAllProductsCooked)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }
        }
    }
}
