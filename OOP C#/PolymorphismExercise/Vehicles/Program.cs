using System;

namespace Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Vehicle firstVehicle = CreateVehicle();
            Vehicle secVehicle = CreateVehicle();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] arg = Console.ReadLine().Split();

                string command = arg[0];
                string vehicleType = arg[1];
                double distanceOrLiters = double.Parse(arg[2]);
                if (command == "Drive")
                {
                    try
                    {
                        if (vehicleType == nameof(Car))
                        {
                            firstVehicle.Drive(distanceOrLiters);
                        }
                        else
                        {
                            secVehicle.Drive(distanceOrLiters);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (command == "Refuel")
                {
                    if (vehicleType == nameof(Car))
                    {
                        firstVehicle.Refuel(distanceOrLiters);
                    }
                    else
                    {
                        secVehicle.Refuel(distanceOrLiters);
                    }
                }
            }

            Console.WriteLine(firstVehicle);
            Console.WriteLine(secVehicle);
        }

        static public Vehicle CreateVehicle()
        {
            string[] vehicleArgs = Console.ReadLine().Split();
            string type = vehicleArgs[0];
            double fuel = double.Parse(vehicleArgs[1]);
            double fuelConsumpiton = double.Parse(vehicleArgs[2]);
            if (type == nameof(Car))
            {
                Vehicle car = new Car(fuel, fuelConsumpiton);
                return car;
            }
            else
            {
                Vehicle truck = new Truck(fuel, fuelConsumpiton);
                return truck;
            }
        }
    }
}
