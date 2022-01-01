using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vechile> vechiles = new List<Vechile>();
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arg = input.Split().ToArray();
                string typeOfVec = arg[0];
                string model = arg[1];
                string color = arg[2];
                double hP = double.Parse(arg[3]);
                Vechile vechile = new Vechile(typeOfVec, model, color, hP);
                vechiles.Add(vechile);
            }

            string vecModel = String.Empty;
            while ((vecModel = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(vechiles.FirstOrDefault(x => x.Model == vecModel).ToString());

                vecModel = Console.ReadLine();
            }

            var cars = vechiles.FindAll(c => c.TypeOfVechile == "car");
            var carsHP = cars.Sum(x => x.HorsePower);
            var carsAvarHP = carsHP / cars.Count;
            if (cars.Count == 0)
            {
                carsAvarHP = 0;
            }

            var trukcs = vechiles.FindAll(c => c.TypeOfVechile == "truck");
            var trucksHP = trukcs.Sum(t => t.HorsePower);
            var truckssAvarHP = trucksHP / trukcs.Count;
            if (0 == trukcs.Count)
            {
                truckssAvarHP = 0;
            }

            Console.WriteLine($"Cars have average horsepower of: {carsAvarHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckssAvarHP:f2}.");
        }
    }
    class Vechile
    {

        public Vechile(string typeOfVec, string model, string color, double hP)
        {
            TypeOfVechile = typeOfVec;
            Model = model;
            Color = color;
            HorsePower = hP;

        }
        public string TypeOfVechile { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double HorsePower { get; set; }
        public override string ToString()
        {
            if (TypeOfVechile =="car")
            {
                Console.WriteLine("Type: Car");
            }
            if (TypeOfVechile == "truck")
            {
                Console.WriteLine("Type: Truck");
            }
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {HorsePower}");
            return sb.ToString().TrimEnd(); 
        }
    }
}
