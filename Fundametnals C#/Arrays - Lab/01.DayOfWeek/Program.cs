using System;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dayOfWeek = {"Monday",
                                   "Tuesday",
                                   "Wednesday",
                                   "Thursday",
                                    "Friday",
                                   "Saturday",
                                   "Sunday"};
            int num = int.Parse(Console.ReadLine());
            if (num > dayOfWeek.Length || num <1)
            {
                Console.WriteLine("Invalid day!");
          
            }
            else
            {
                Console.WriteLine(dayOfWeek[num - 1]);
            }
        
        }
    }
}
