using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        private List<Car> cars;
        public int Capacity { get; set; }
        public string Type { get; set; }

        public Parking(string type, int capacity)
        {
            this.Type = type;
            this.Capacity = capacity;
            cars = new List<Car>();
        }

        public void Add(Car car)
        {
            if (cars.Count - 1 <= Capacity)
            {
                cars.Add(car);
            }
        }

        public bool Remove(string manifacturer, string model)
        {
            Car car = cars.FirstOrDefault(c => c.Manufacturer == manifacturer && c.Model == model);

            if (car != null)
            {
                cars.Remove(car);
                return true;
            }
            else
            {
                return false;
            }        
        }

        public Car GetLatestCar()
        {
            Car car = cars.OrderByDescending(c=>c.Year).First();

            return car;
        }

        public Car GetCar(string manifacturer, string model)
        {
            Car car = cars.FirstOrDefault(c => c.Manufacturer == manifacturer && c.Manufacturer == model);

            return car;
        }

        public int Count => cars.Count;

        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {this.Type}:");

            if (cars.Count != 0)
            {
                foreach (Car car in cars)
                {
                    sb.AppendLine($"{car}");
                }
            }
            return sb.ToString().TrimEnd();
        }

    }
}
