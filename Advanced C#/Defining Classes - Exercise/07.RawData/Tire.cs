using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        public int Year { get; set; }

        public double Presure { get; set; }

        public Tire(double presure, int year)
        {
            Year = year;
            Presure = presure;
        }
    }
}
