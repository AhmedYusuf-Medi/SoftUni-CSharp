using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model,string colo,int battery)
        {
            this.Model = model;
            this.Color = colo;
            this.Baterry = battery;
        }
        public int Baterry { get;  set; }
        public string Model { get;  set; }
        public string Color { get;  set; }
        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        void ICar.ToString()
        {
            Console.WriteLine($"{this.Color} Tesla {this.Model} with {this.Baterry}");
        }
    }
}
