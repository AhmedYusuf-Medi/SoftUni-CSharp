using System;
using System.Collections.Generic;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split();
            var websites = Console.ReadLine().Split();

            SmartPhone smartPhone = new SmartPhone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            foreach (var number in numbers)
            {
                try
                {
                    if (number.Length == 10)
                    {
                        smartPhone.Calling(number);
                    }
                    else
                    {
                        stationaryPhone.Calling(number);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var website in websites)
            {
                try
                {
                    smartPhone.Browsing(website);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
