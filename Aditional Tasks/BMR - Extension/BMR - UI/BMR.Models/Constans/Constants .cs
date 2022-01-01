namespace BMR.Models.Constans
{
    public static class Constans
    {
        public static class PersonConstants
        {
            //Gender constants
            public const int MIN_AGE = 7;
            public const int MAX_AGE = 80;
            public const double MIN_HEIGHT = 120;
            public const double MAX_HEIGHT = 260;
            public const double MIN_WEIGHT = 30;
            public const double MAX_WEIGHT = 300;

            public const double LITTLE_NO_EXERCISE = 1.2;
            public const double LIGHT_EXERCISE = 1.375;
            public const double MODERATE_EXERCISE = 1.55;
            public const double VERY_ACTIVE = 1.725;
            public const double EXTRA_ACTIVE = 1.9;

            public const double PROTEIN_PERCENTAGE = 0.4;
            public const double CARB_PERCENTAGE = 0.4;
            public const double FAT_PERCENTAGE = 0.2;

            public const int CALORIE_PER_PROTEIN = 4;
            public const int CALORIE_PER_CARB = 4;
            public const int CALORIE_PER_FAT = 4;

            public const int CALORIE_SURPLUS_FOR_BULKING = 200;
            public const int CALORIE_DEFICIT_FOR_CUTTING = 150;
        }

        public static class WomenConstants
        {
            //Women constants
            public const double WOMEN_MUST_CALORIES = 655.1;
            public const double WOMEN_WEIGHT_MULTIPLIER = 9.563;
            public const double WOMEN_HEIGHT_MULTIPLIER = 1.85;
            public const double WOMEN_AGE_MULTIPLIER = 4.676;
        }

        public static class MenConstants
        {  //Men constants
            public const double MEN_MUST_CALORIES = 66.47;
            public const double MEN_WEIGHT_MULTIPLIER = 13.75;
            public const double MEN_HEIGHT_MULTIPLIER = 5.003;
            public const double MEN_AGE_MULTIPLIER = 6.755;
        }
    }
}