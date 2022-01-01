using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private int NameMinLenght = 1;
        private int NameMaxLenght = 15;

        private int MaxToppings = 10;
        private int MinToppings = 0;

        private string name;
        private Dough dough;
        private List<Topping> toppings;

        public Pizza(string name,Dough dough)
        {
            this.Name = name;
            this.dough = dough;

            toppings = new List<Topping>();
        }
        private string Name
        {
            get => this.name;

            set
            {
                if (value.Length < NameMinLenght || value.Length > NameMaxLenght)
                {
                    throw new ArgumentException($"Pizza name should be between " +
                        $"{NameMinLenght} and {NameMaxLenght}  symbols.");
                }

                this.name = value;
            }
        }

        public void AddTopping(Topping topping)
        {
            if (this.toppings.Count == 10)
            {
                throw new InvalidOperationException($"Number of toppings should be in " +
                    $"range [{MinToppings}..{MaxToppings}].");
            }

            this.toppings.Add(topping);
        }

        public double GetCalories()
        {
            double result = this.dough.CalcCalories() + this.toppings.Sum(t => t.CalcCalories());
            return result;
        }
    }
}
