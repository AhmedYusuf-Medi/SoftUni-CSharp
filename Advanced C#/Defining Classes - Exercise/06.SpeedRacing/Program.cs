using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            GetCars(n, cars);

            string text;
            text = CarToDrive(cars);

            Print(cars);
        }

        private static void Print(List<Car> cars)
        {
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }

        private static string CarToDrive(List<Car> cars)
        {
            string text;
            while ((text = Console.ReadLine()) != "End")
            {
                string[] arg = text.Split();
                string comand = arg[0];
                string carModel = arg[1];
                double amoutOfKm = double.Parse(arg[2]);

                Car carToDrive = cars.Where(n => n.Model == carModel).ToList().First();

                carToDrive.Drive(amoutOfKm);
            }

            return text;
        }

        private static void GetCars(int n, List<Car> cars)
        {
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptonPerOneKm = double.Parse(input[2]);
                double traveDistance = 0;

                Car car = new Car(model, fuelAmount, fuelConsumptonPerOneKm, traveDistance);

                cars.Add(car);
            }
        }
    }
}
