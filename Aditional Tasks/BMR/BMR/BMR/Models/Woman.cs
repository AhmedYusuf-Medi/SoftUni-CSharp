using System;

namespace BMR
{
    public class Woman : Gender
    {
        public Woman(GenderType gender, byte age, byte height, float weight,string activity)
            : base(gender, age, height, weight,activity)
        {
        }

        public override int GetBasalMetabolicRate()
        {
            //BMR for Women = 655.1 + (9.563 * weight [kg]) + (1.85 * size [cm]) − (4.676 * age [years])
            int calculation = (int)Math.Floor(655.1 +(9.563 * this.Weight) + (1.85 * this.Height) - (4.676 * this.Age));
            this.BMR = calculation;
            return calculation;
        }
    }
}
