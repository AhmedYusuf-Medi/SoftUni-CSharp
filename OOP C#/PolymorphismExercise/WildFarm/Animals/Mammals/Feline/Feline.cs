using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Feline : Mammal
    {
        public Feline(string name, double weight, HashSet<string> foods, 
            double weightModifier, string region,string breed) 
            : base(name, weight, foods, weightModifier, region)
        {
            this.Breed = breed;
        }

        public string Breed { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, " +
                $"{this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
