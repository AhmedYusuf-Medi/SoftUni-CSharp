using System;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Opel";
            car.Model = "Astra";
            car.Year = 1995;

            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Make : {car.Make}");
            sb.AppendLine($"Model : {car.Model}");
            sb.AppendLine($"Year : {car.Year}");
            Console.WriteLine(sb);
        }
    }
}
