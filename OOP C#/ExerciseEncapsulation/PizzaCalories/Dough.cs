using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private int MinWeight = 1;
        private int MaxWeight = 200;
        private string flourType;
        private string bakingTechnique;
        private int weight;

        public Dough(string flourType,string bakingTechnique,int weight)
        {
            this.FlourType = flourType;
            this.BakingTechnique = bakingTechnique;
            this.Weight = weight;
        }
        private string FlourType
        {
            get => this.flourType;
            set
            {
                List<string> types =
                    new List<string> { "white", "wholegrain" };
                bool typeCheck = types.Contains(value.ToLower());
                if (string.IsNullOrEmpty(value) || !typeCheck)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.flourType = value;
            }
        }


        private string BakingTechnique
        {
            get => this.bakingTechnique;
            set
            {
                List<string> types =
                    new List<string> { "crispy", "chewy", "homemade" };
                bool typeChck = types.Contains(value.ToLower());
                if (string.IsNullOrEmpty(value) || !typeChck)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                this.bakingTechnique = value;
            }
        }

        private int Weight
        {
            get => this.weight;
            set
            {
                if (value < MinWeight || value > MaxWeight)
                {
                    throw new ArgumentException($"Dough weight should be in the range [{MinWeight}...{MaxWeight}].");
                }

                this.weight = value;
            }
        }

        public double CalcCalories()
        {
            double flourTypeCalories = GetFlourTypeModifier();
            double techniqueCalories = GetTechniqueTypeModifier();
            double result = this.Weight * 2 * flourTypeCalories * techniqueCalories;

            return result;
        }

        private double GetTechniqueTypeModifier()
        {
            string technique = this.BakingTechnique.ToLower();
            if (technique == "crispy")
            {
                return 0.9;
            }
            if (technique =="chewy")
            {
                return 1.1;
            }
            return 1.0;
        }

        private double GetFlourTypeModifier()
        {
            string flourType = this.FlourType.ToLower();
            if (flourType == "white")
            {
                return 1.5;
            }

            return 1.0;
        }
    }
}
