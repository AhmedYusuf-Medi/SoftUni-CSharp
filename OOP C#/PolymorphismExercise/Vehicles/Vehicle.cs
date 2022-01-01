using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        public Vehicle(double fuel, double fuelConsumption, double airConditioner)
        {
            this.Fuel = fuel;
            this.FuelConsumption = fuelConsumption;

            this.AirConditonerModifier = airConditioner;
        }
        public double Fuel { get; private set; }
        public double FuelConsumption { get; private set; }

        private double AirConditonerModifier { get; set; }
        public void Drive(double distance)
        {
            double fuelNeeded = distance * (FuelConsumption + AirConditonerModifier);

            if (fuelNeeded > this.Fuel)
            {
                throw new InvalidOperationException($"{ this.GetType().Name } needs refueling");
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
                this.Fuel -= fuelNeeded;
            }
        }

        public virtual void Refuel(double fuel)
        {
            this.Fuel += fuel;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.Fuel:f2}";
        }
    }
}
