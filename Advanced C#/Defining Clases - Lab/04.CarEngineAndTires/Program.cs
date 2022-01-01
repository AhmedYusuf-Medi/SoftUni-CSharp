using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {

            Engine pR = new Engine(400, 12011);

            Tire[] tires = new Tire[]
                {
                    new Tire(2005,2.2),
                    new Tire(2005,2.4),
                    new Tire(2005,2.3),
                    new Tire(2005,2.5),
                };

            Car brumchalka = new Car("Opel", "Corsa", 1500, 600, -30, pR,tires);



            Console.WriteLine($"Horse power: {brumchalka.Engine.HorsePower}");

            foreach (var tire in brumchalka.Tires)
            {
                Console.WriteLine($"{tire.Year} - {tire.Presure}");
            }
        }
    }
}
