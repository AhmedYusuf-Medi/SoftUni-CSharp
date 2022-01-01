using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;

        public int Count => this.cars.Count;

        public Parking(int capacity)
        {
            this.capacity = capacity;
            this.cars = new List<Car>();
        }

        public string AddCar(Car car)
        {
            if (this.cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Car with that registration number,already exists!");
                return sb.ToString();
            }
            if(this.cars.Count > capacity)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Parking is full!");
                return sb.ToString();
            }
            else
            { 
                this.cars.Add(car);
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Successfully added new car {car.Make} {car.RegistrationNumber}!");
                return sb.ToString();
            }
        }

        public string RemoveCar(string registrationNumver)
        {
            if (this.cars.All(c => c.RegistrationNumber == registrationNumver))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Car with that registration number, doesn't exist!");
                return sb.ToString();
            }
            else
            {
                this.cars = cars.Where(c => c.RegistrationNumber != registrationNumver).ToList();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Successfully removed {registrationNumver}");
                return sb.ToString();
            }
        }

        public Car GetCar(string registrationNumber)
        {
            Car car = this.cars.FirstOrDefault(c => c.RegistrationNumber == registrationNumber);
            return car;
        }

        public void RemoveSetOfRegistrationNumbers(List<string> registrationNumbers)
        {
            foreach (var registrationNum in registrationNumbers)
            {
                Car car = this.cars.FirstOrDefault(c => c.RegistrationNumber == registrationNum);

                if (car != null)
                {
                    this.cars.Remove(car);
                }
            }

        }
    }
}
