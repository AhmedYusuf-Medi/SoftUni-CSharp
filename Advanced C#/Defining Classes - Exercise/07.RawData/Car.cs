using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class Car
    {
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public Tire[] Tires { get; set; }

        public Car(Engine engine, Cargo cargo, Tire[] tires)
        {
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tires = tires;
        }
    }
}
