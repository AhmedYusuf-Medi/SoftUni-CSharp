using System;

namespace BMR
{
    public class Gender
    {
        private const int minAge = 7;
        private const int maxAge = 80;

        private const double LittleNoExercise = 1.2;
        private const double LightExercise = 1.375;
        private const double ModerateExercise = 1.55;
        private const double VeryActive = 1.725;
        private const double ExtraActive = 1.9;

        private const int calorieSurplusForBulking = 200;
        private const int calorieDeficitForCutting = 200;

        private GenderType _gender;
        private byte _age;
        private byte _height;
        private float _weight;
        private int _bmr;

        public Gender(GenderType gender,byte age,byte height,float weight,string activity)
        {
            this.GenderProperty = gender;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
            this.BMR = CalculateBMRAfterGettingActivity(activity);
        }

        public GenderType GenderProperty
        {
            get => this._gender;
            private set 
            {
                Error.GenderValidator(value);
                this._gender = value;
            }
        }
        public byte Age 
        {
            get => this._age;
            private set 
            {
                Error.AgeValidator(value, minAge, maxAge);
                this._age = value;
            } 
        }

        public byte Height 
        {
            get => this._height;
            private set
            {
                Error.IsValueNegativeOrZero(value);
                this._height = value;
            }
        }

        public float Weight
        {
            get => this._weight;
            private set
            {
                Error.IsValueNegativeOrZero(value);
                this._weight = value;
            }
        }

        public int BMR 
        {
            get => this._bmr;
            set 
            {
                this._bmr = value;
            }
        }
        public void Update(GenderType gender = default(GenderType), byte age = 1, byte height = 1, float weight = 1)
        {
            if (gender != default(GenderType))
            {
                this._gender = gender;
            }

            if (age != 1)
            {
                this._age = age;
            }

            if (height != 1)
            {
                this._height = height;
            }

            if (weight != 1)
            {
                this._weight = weight;
            }
        }

        public virtual int GetBasalMetabolicRate()
        {
            throw new ArgumentException();
        }
        public virtual int CalculateBMRAfterGettingActivity(string activity)
        {
            double bmr = GetBasalMetabolicRate();

            if (activity.ToLower().StartsWith("sedentary"))
            {
                bmr = bmr * LittleNoExercise;
            }
            else if (activity.ToLower().StartsWith("light"))
            {
                bmr = bmr * LightExercise;
            }
            else if (activity.ToLower().StartsWith("moderate"))
            {
                bmr = bmr * ModerateExercise;
            }
            else if (activity.ToLower().StartsWith("very"))
            {
                bmr = bmr * VeryActive;
            }
            else
            {
                bmr = bmr * ExtraActive;
            }

            return (int)Math.Floor(bmr);
        }
        public void Bulk(int calories = calorieSurplusForBulking)
        {
            this._bmr += calories;
        }

        public void Cut(int calories = calorieDeficitForCutting)
        {
            this._bmr -= calories;
        }
    }
}
