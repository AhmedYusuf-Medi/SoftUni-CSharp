using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Mouse : Mammal
    {
        private const double weightModifier = 0.1;
        private static HashSet<string> foods = new HashSet<string>
        {
            nameof(Vegetable),
            nameof(Fruit)
        };
        public Mouse(string name, double weight,string region) :
            base(name, weight, foods, weightModifier, region)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Squeak");
        }
    }
}
