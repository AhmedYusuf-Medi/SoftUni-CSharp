using System;

namespace _03.Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Friday Saturday    Sunday
            //Students    8.45    9.80    10.46
            //Business    10.90   15.60   16
            //Regular      15        20  22.50

            int peopleNum = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double totalPrice = 0;

            if (typeOfGroup == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = peopleNum * 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = peopleNum * 9.8;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = peopleNum * 10.46;
                }
                if (peopleNum >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            if (typeOfGroup == "Business")
            {
                if (peopleNum >= 100)
                {
                    peopleNum -= 10;
                }
                if (dayOfWeek == "Friday")
                {
                    totalPrice = peopleNum * 10.9;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = peopleNum * 15.6;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = peopleNum * 16;
                }
            }
            if (typeOfGroup == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = peopleNum * 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = peopleNum * 20;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = peopleNum * 22.5;
                }
                if (peopleNum >= 10 && peopleNum <= 20)
                {
                    totalPrice *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
