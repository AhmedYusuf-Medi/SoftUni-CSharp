using System;
using System.Collections.Generic;
using System.Text;

namespace BMR
{
    public static class Error
    {
        public static void GenderValidator(GenderType gender)
        {
            if (gender != GenderType.Men && gender != GenderType.Woman)
            {
                throw new ArgumentOutOfRangeException("Invalid gender, gender must be Men or Woman!");
            }
        }

        public static void AgeValidator(int age,int minAge,int maxAge)
        {
            if (age < minAge && age > maxAge)
            {
                throw new ArgumentOutOfRangeException("Invalid age, age must be beetwen 15 and 80!");
            }
        }

        public static void IsValueNegativeOrZero(float value)
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Invalid input, it must be positive number and other than 0.");
            }
        }
    }
}
