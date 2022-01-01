using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private int MinWeight = 1;
        private int MaxWeight = 50;
        private string toppingType;
        private int grams;


        public Topping(string toppingType, int grams)
        {
            this.ToppingType = toppingType;
            this.Grams = grams;
        }
        private string ToppingType
        {
            get => this.toppingType;
            set
            {
                List<string> toppingType =
                    new List<string> { "meat", "veggies", "cheese", "sauce" };
                bool checkToppings = toppingType.Contains(value.ToLower());
                if (string.IsNullOrEmpty(value) || !checkToppings)
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                this.toppingType = value;
            }
        }

        private int Grams
        {
            get => this.grams;
            set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"{this.ToppingType} weight should be in the range " +
                        $"[{MinWeight}..{MaxWeight}].");
                }

                this.grams = value;
            }
        }

        public double CalcCalories()
        {
            double toppingType = GetToppingTypeCalories();
            int weight = this.Grams;
            double result = toppingType * weight * 2;
            return result;
        }

        private double GetToppingTypeCalories()
        {
            string topping = this.ToppingType.ToLower();
            switch (topping)
            {
                case "meat":
                    return 1.2;
                case "veggies":
                    return 0.8;
                case "cheese":
                    return 1.1;
                default:
                    return 0.9;
            }
        }
    }
}
