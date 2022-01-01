using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Hen : Bird
    {
        private const double weightModifier = 0.35;

        private static HashSet<string> foods = new HashSet<string>
        {
            nameof(Vegetable),
            nameof(Fruit),
            nameof(Meat),
            nameof(Seeds)
        };

        public Hen(string name, 
            double weight,
            double wingSize) 
            : base(name, weight, foods, weightModifier, wingSize)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Cluck");
        }
    }
}
