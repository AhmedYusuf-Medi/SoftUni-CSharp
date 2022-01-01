using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        private const double AirConditioner = 0.9;
        public Car(double fuel, double fuelConsumption)
            : base(fuel, fuelConsumption, AirConditioner)
        {
        }

    }
}
