using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Dog : Mammal
    {
        private const double weightModifier = 0.4;

        private static HashSet<string> foods = new HashSet<string>
        {
            nameof(Meat)
        };
        public Dog(string name, double weight, string region) 
            : base(name, weight, foods, weightModifier, region)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
