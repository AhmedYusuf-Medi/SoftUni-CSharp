using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WildFarm
{
    public abstract class Animal
    {
        public Animal(string name, double weight,
            HashSet<string> foods,
            double weightModifier)
        {
            this.Name = name;
            this.Weight = weight;
            this.AllowedFood = foods;
            this.WeightModifier = weightModifier;
        }

        public string Name { get;private set; }
        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public HashSet<string> AllowedFood { get; private set; }

        private double WeightModifier { get; set; }

        public void Eat(Food food)
        {
            string foodType = food.GetType().Name;
            string name = this.GetType().Name;

            if (!AllowedFood.Contains(foodType))
            {
                Console.WriteLine($"{name} does not eat {foodType}"!);
            }
            else
            {
                this.FoodEaten += food.FoodQuantity;

                this.Weight += this.WeightModifier * food.FoodQuantity;
            }
        }
        public virtual void ProduceSound()
        {
        }
    }
}
