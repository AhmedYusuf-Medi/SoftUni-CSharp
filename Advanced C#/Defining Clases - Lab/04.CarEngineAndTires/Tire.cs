using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        public int Year { get; set; }

        public double Presure { get; set; }

        public Tire (int year,double presure)
        {
            Year = year;
            Presure = presure;
        }

    }
}
