using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    public class Tiger : Feline
    {
        private const double weightModifier = 1;

        private static HashSet<string> foods = new HashSet<string>
        {
            nameof(Meat)
        };
        public Tiger(string name, double weight, string region, string breed)
            : base(name, weight, foods, weightModifier, region, breed)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("ROAR!!!");
        }
    }
}
