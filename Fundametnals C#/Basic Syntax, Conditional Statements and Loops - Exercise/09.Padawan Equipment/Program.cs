using System;

namespace _09.Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int extraSabers = (int)Math.Ceiling(studentCount * 0.10);
            int freeBelts = studentCount / 6;

            double total = (lightsaberPrice * (studentCount + extraSabers))
                + (robePrice * studentCount) + (beltPrice * (studentCount - freeBelts));

            if (money >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:f2}lv.");
            }
            else
            {
                total = total - money;

                Console.WriteLine($"John will need {total:f2}lv more.");
            }
        }
    }
}
