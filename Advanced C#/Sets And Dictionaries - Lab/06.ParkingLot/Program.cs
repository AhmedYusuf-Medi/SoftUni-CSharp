using System;
using System.Collections.Generic;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> cars = new HashSet<string>();

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] arg = input.Split(", ");
                string comand = arg[0];
                string carNumber = arg[1];

                if (comand =="IN")
                {
                    cars.Add(carNumber);
                }
                else
                {
                    if (cars.Count > 0)
                    {
                        cars.Remove(carNumber);
                    }
                }
            }

            if (cars.Count >0)
            {
                Console.WriteLine(string.Join(Environment.NewLine,cars));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
