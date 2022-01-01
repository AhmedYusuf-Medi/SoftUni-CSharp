using System;

namespace BMR
{
    public class Men : Gender
    {
        public Men(GenderType gender, byte age, byte height, float weight,string activity) 
            : base(gender, age, height, weight,activity)
        {
        }

        public override int GetBasalMetabolicRate()
        {
            //BMR for Men = 66.47 + (13.75 * weight[kg]) + (5.003 * size[cm]) − (6.755 * age[years]);
            int calculation = (int)Math.Floor(66.47 + (13.75 * this.Weight) + (5.003 * this.Height) - (6.775 * this.Age));
            this.BMR = calculation;
            return calculation;
        }    

    }
}
