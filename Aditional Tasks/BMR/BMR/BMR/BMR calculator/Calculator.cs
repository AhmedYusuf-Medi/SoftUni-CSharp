using System;
using System.Text;

namespace BMR
{
    public class Calculator
    {
        private const string CaloriesFinalOutput = "Your current calories are : ";
        private const string GenderEntranceText = "Please enter your gender (Men or Woman): ";
        private const string AgeEntranceText = "Please enter your age [15-80]: ";
        private const string HeightEntranceText = "Please enter your height: ";
        private const string WeightEntranceText = "Please enter your weight: ";
        private const string MethodOptionEntranceText = "Please chose what's your chose [Bulk,Cut or Maintance]: ";
        private const string bulk = "Bulk";
        private const string cut = "Cut";
        private const string ActivityEntranceText = "Please choice activity that fits you: ";
        public void Run()
        {
            Gender user = CreateUser();
            ChooseMethodOfManipulatingBW(user);
            PrintBMR(user);
        }

        private static void PrintBMR(Gender user)
        {
            Console.WriteLine();
            PrintLine($"{CaloriesFinalOutput}{user.BMR}");
        }

        private static Gender CreateUser()
        {
            Print(GenderEntranceText);
            string gender = Console.ReadLine();
            Print(AgeEntranceText);
            byte age = byte.Parse(Console.ReadLine());
            Print(HeightEntranceText);
            byte height = byte.Parse(Console.ReadLine());
            Print(WeightEntranceText);
            float weight = float.Parse(Console.ReadLine());
            string activity = ChooseActivity();

            GenderType realGender;
            Gender user;
            if (gender == GenderType.Men.ToString())
            {
                realGender = GenderType.Men;
                user = new Men(realGender, age, height, weight,activity);
            }
            else
            {
                realGender = GenderType.Woman;
                user = new Woman(realGender, age, height, weight,activity);
            }

            Console.WriteLine(user.BMR);
            return user;
        }
        private static void ChooseMethodOfManipulatingBW(Gender user)
        {
            Print(MethodOptionEntranceText);
            string method = Console.ReadLine();

            switch (method)
            {
                case bulk:
                    user.Bulk();
                    break;
                case cut:
                    user.Cut();
                    break;
                default:
                    break;
            }
        }
        private static string ChooseActivity()
        {
            PrintLine(CreateActivityList());
            Console.Write(ActivityEntranceText);
            return Console.ReadLine();
        }
        private static string CreateActivityList()
        {
            //Activity Level  Calorie
            //Sedentary: little or no exercise   
            //Exercise 1 - 3 times / week
            //Exercise 4 - 5 times / week
            //Daily exercise or intense exercise 3 - 4 times / week 
            //Intense exercise 6 - 7 times / week 
            //Very intense exercise daily, or physical job 

            //Exercise: 15 - 30 minutes of elevated heart rate activity.
            //Intense exercise: 45 - 120 minutes of elevated heart rate activity.
            //Very intense exercise: 2 + hours of elevated heart rate activity.

            StringBuilder activityList = new StringBuilder();
            activityList.AppendLine(new string('-',66));
            activityList.AppendLine($"{new string(' ',23)}Intro{new string(' ', 23)}");
            activityList.AppendLine("Exercise: 15 - 30 minutes of elevated heart rate activity.");
            activityList.AppendLine("Intense exercise: 45 - 120 minutes of elevated heart rate activity.");
            activityList.AppendLine("Very intense exercise: 2 + hours of elevated heart rate activity.");
            activityList.AppendLine(new string('-', 66));
            activityList.AppendLine($"{new string(' ', 17)}Make your choice{new string(' ', 18)}");
            activityList.AppendLine("Activity Level Calorie");
            activityList.AppendLine("Sedentary: little or no exercise");
            activityList.AppendLine("Light exercise: Exercise 1 - 3 times / week");
            activityList.AppendLine("Moderate exercise: Daily exercise or intense exercise 3 - 4 times / week");
            activityList.AppendLine("Very Active: Intense exercise 6 - 7 times / week ");
            activityList.AppendLine("Extra active: exercise daily, or physical job ");
            activityList.AppendLine();
            return activityList.ToString().TrimEnd();
        }
        private static void PrintLine(string text)
        {
            Console.WriteLine(text);
        }

        private static void Print(string text)
        {
            Console.Write(text);
        }

    }
}
