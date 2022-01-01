using System;

namespace _4.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeToGetBack = 30;

            minutes += timeToGetBack;

            while (minutes >=  60)
            {
                minutes -= 60;
                hours += 1;
            }

            while (hours >= 24)
            {
                hours -= 24;
            }

            if (minutes.ToString().Length > 1)
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }

        }
    }
}
