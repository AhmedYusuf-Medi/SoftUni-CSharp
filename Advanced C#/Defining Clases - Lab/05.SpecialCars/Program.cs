using CarManufacturer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.SpecialCars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();

            string command;

            while ((command = Console.ReadLine()) != "No more tires")
            {
                string[] currArr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var currTires = new Tire[4]
                {
                    new Tire(int.Parse(currArr[0]), double.Parse(currArr[1])),
                    new Tire(int.Parse(currArr[2]), double.Parse(currArr[3])),
                    new Tire(int.Parse(currArr[4]), double.Parse(currArr[5])),
                    new Tire(int.Parse(currArr[6]), double.Parse(currArr[7]))
                };

                tires.Add(currTires);
            }

            List<Engine> engines = new List<Engine>();

            while ((command = Console.ReadLine()) != "Engines done")
            {
                string[] currArr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var engine = new Engine(int.Parse(currArr[0]), double.Parse(currArr[1]));
                engines.Add(engine);
            }

            List<Car> cars = new List<Car>();

            while ((command = Console.ReadLine()) != "Show special")
            {
                string[] currArr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                var make = currArr[0];
                var model = currArr[1];
                var year = int.Parse(currArr[2]);
                var fuelQuantity = double.Parse(currArr[3]);
                var fuelCapacity = double.Parse(currArr[4]);
                var engineIndex = int.Parse(currArr[5]);
                var tireIndex = int.Parse(currArr[6]);

                if ((engineIndex >= 0 && engineIndex < engines.Count) && (tireIndex >= 0 && tireIndex < tires.Count))
                {
                    var car = new Car(make, model, year, fuelQuantity, fuelCapacity, engines[engineIndex], tires[tireIndex]);
                    cars.Add(car);
                }
            }
            cars = cars.Where(x => x.Year >= 2017 && x.Engine.HorsePower > 330 && x.Tires.Sum(y => y.Presure) >= 9 && x.Tires.Sum(y => y.Presure) <= 10).ToList();

            if (cars.Any())
            {
                foreach (var car in cars)
                {
                    StringBuilder builder = new StringBuilder();

                    car.Drive(20);

                    builder.AppendLine($"Make: {car.Make}");
                    builder.AppendLine($"Model: {car.Model}");
                    builder.AppendLine($"Year: {car.Year.ToString()}");
                    builder.AppendLine($"HorsePowers: {car.Engine.HorsePower.ToString()}");
                    builder.AppendLine($"FuelQuantity: {car.FuelQuantity.ToString()}");

                    Console.Write(builder);
                }
            }
        }
    }
}

