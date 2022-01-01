using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }



        //private string make;
        //private string model;
        //private int year;
        //private double fuelQuantity;
        //private double fuelComsumption;

        //public string Make 
        //{
        //    get { return make; }
        //    set { make = value; }
        //}

        //public string Model 
        //{
        //    get { return model; }
        //    set { model = value; }
        //}
        //public int Year 
        //{
        //    get { return year; }
        //    set { year = value; }
        //}
        //public double FuelQuantity 
        //{
        //    get { return fuelQuantity; }
        //    set { fuelQuantity = value; }
        //}
        //public double FuelConsumption
        //{
        //    get { return fuelComsumption; }
        //    set { fuelComsumption = value; }
        //}

        public void Drive(double distance)
        {
            double fuelConsumed = FuelConsumption * distance;
            if (FuelQuantity - fuelConsumed >=0)
            {
                FuelQuantity -= fuelConsumed;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public StringBuilder WhoAmi()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {this.Make}");
            sb.AppendLine($"Model: {this.Model}");
            sb.AppendLine($"Year: {this.Year}");
            sb.AppendLine($"Fuel: {this.FuelQuantity:f2}L");

            return sb;
        }
    }
}
