using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Owl : Bird
    {
        private const double weightModifier = 0.25;

        private static HashSet<string> foods = new HashSet<string>
        {
            nameof(Meat)
        };

        public Owl(string name, double weight,
            double wingSize) 
            : base(name, weight, foods, weightModifier, wingSize)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Hoot Hoot");
        }
    }
}
