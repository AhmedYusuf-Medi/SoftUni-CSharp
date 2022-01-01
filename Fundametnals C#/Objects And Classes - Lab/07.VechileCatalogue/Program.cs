
using System;
using System.Collections.Generic;

namespace _07.VechileCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Car> cars = new List<Car>();

            List<Truck> trucks = new List<Truck>();

            while (input != "end")
            {
                string[] tokens = input.Split("/");
                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int powerOrWeight = int.Parse(tokens[3]);

                if (type == "Car")
                {
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = powerOrWeight;

                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = powerOrWeight;

                    trucks.Add(truck);
                }
                input = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                cars.Sort((x, y) => string.Compare(x.Brand, y.Brand));
                Console.WriteLine("Cars:");
                foreach (var car in cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (trucks.Count > 0)
            {
                trucks.Sort((x, y) => string.Compare(x.Brand, y.Brand));
                Console.WriteLine("Trucks:");
                foreach (var truck in trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }


        }
    }
}
