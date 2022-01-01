using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        private const double airConditioner = 1.6;
        public Truck(double fuel, double fuelConsumption) 
            : base(fuel, fuelConsumption, airConditioner)
        {
        }

        public override void Refuel(double fuel)
        {
            base.Refuel(fuel * 0.95);

        }
    }
}
