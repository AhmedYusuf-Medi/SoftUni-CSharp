using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mammal : Animal
    {
        public Mammal(string name, double weight,
            HashSet<string> foods, double weightModifier,string region) 
            : base(name, weight, foods, weightModifier)
        {
            this.LivingRegion = region;
        }

        public string LivingRegion { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, " +
                $"{this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
