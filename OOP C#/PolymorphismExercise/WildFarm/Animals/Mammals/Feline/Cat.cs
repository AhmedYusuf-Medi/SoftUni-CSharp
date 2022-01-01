using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Cat : Feline
    {
        private const double weightModifier = 0.3;

        private static HashSet<string> foods = new HashSet<string>
        {
            nameof(Meat),
            nameof(Vegetable)
        };

        public Cat(string name, double weight, 
            string region, string breed) 
            : base(name, weight, foods, weightModifier, region, breed)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
