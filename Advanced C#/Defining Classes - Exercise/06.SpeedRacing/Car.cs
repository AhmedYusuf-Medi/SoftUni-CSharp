using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {

        public Car(string model, double fuelAmount, double fuelConsumptonPerOneKm, double traveDistance)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumtionPerKilometer = fuelConsumptonPerOneKm;
            this.TravelledDistance = traveDistance;
        }

        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelConsumtionPerKilometer { get; set; }

        public double TravelledDistance { get; set; }

        public void Drive(double amountOfKm)
        {
            double fuelConsumed =FuelConsumtionPerKilometer * amountOfKm;
            if (FuelAmount - fuelConsumed >= 0)
            {
                FuelAmount -= fuelConsumed;
                TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }


    }
}
