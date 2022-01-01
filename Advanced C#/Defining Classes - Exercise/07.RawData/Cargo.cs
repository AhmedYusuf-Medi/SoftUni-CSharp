using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cargo
    {
        public double Weight { get; set; }
        public string CargoType { get; set; }

        public Cargo(double weight,string cargoType)
        {
            this.Weight = weight;
            this.CargoType = cargoType;
        }
    }
}
