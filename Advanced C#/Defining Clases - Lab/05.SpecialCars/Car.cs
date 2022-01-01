using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }



        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public void Drive(double distance)
        {
            double fuelConsumed = FuelConsumption * distance;
            if (FuelQuantity - fuelConsumed >= 0)
            {
                FuelQuantity -= fuelConsumed;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }
        public Car(string make, string model, int year)
            :this()
        {
            Make = make;
            Model = model;
            Year = year;
        }

    
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumpion)
            :this(make,model,year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumpion;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumpion,Engine engine,Tire[] tires)
            : this(make, model, year,fuelQuantity,fuelConsumpion)
        {
            this.Engine = engine;
            this.Tires = tires;
        }
    }
}
