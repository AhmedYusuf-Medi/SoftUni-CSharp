using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            GetCars(n, cars);

            string comand = Console.ReadLine();

            PrintCargoType(cars, comand);
        }

        private static void PrintCargoType(List<Car> cars, string comand)
        {
            if (comand == "fragile")
            {
                cars.Where(x => x.Cargo.CargoType == comand)
                .Where(t => t.Tires.Any(x => x.Presure < 1))
                .ToList()
                .ForEach(x => Console.WriteLine(x.Engine.EngineModel));
            }
            else
            {
                cars.Where(c => c.Cargo.CargoType == comand)
                    .Where(e => e.Engine.EnginePower > 250)
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.Engine.EngineModel));
            }
        }

        private static void GetCars(int n, List<Car> cars)
        {
            for (int i = 0; i < n; i++)
            {
                string[] arg = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string model = arg[0];
                double engineSpeed = double.Parse(arg[1]);
                double enginePower = double.Parse(arg[2]);

                Engine engine = new Engine(model, engineSpeed, enginePower);

                double cargoWeight = double.Parse(arg[3]);
                string cargoType = arg[4];

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                double[] presure = new double[] { double.Parse(arg[5]), double.Parse(arg[7]), double.Parse(arg[9]), double.Parse(arg[11]) };
                int[] year = new int[] { int.Parse(arg[6]), int.Parse(arg[8]), int.Parse(arg[10]), int.Parse(arg[12]) };
                Tire[] tires = new Tire[]
                {

                    new Tire(presure[0],year[0]),
                    new Tire(presure[1],year[1]),
                    new Tire(presure[2],year[2]),
                    new Tire(presure[3],year[3]),
                };

                Car car = new Car(engine, cargo, tires);
                cars.Add(car);
            }
        }
    }
}
