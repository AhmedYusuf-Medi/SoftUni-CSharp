using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
    public class BaseHero
    {
        private string name;
        private int power;
        public BaseHero(string name,int power)
        {
            this.Name = name;
            this.Power = power;
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Name cannot be null or empty!");
                }
                this.name = value;
            }
        }
        public int Power 
        {
            get => this.power;
            private set 
            {
                if (value < 0)
                {
                    Console.WriteLine("Power cannot be negative!");
                }
                this.power = value;
            }
        }

        public virtual string CastAbilityForFighters()
        {
            return $"{this.GetType().Name} - {this.Name} hit for {this.Power} damage";
        }

        public virtual string CastAbilityForHealer()
        {
            return $"{this.GetType().Name} - {this.Name} healed for {Power}";
        }
    }
}
