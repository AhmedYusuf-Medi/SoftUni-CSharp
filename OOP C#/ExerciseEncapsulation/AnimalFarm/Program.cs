using System;

namespace AnimalFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
                Chicken chick = new Chicken(name, age);

                Console.WriteLine($"Chicken {chick.Name} (age {chick.Age}) can produce {chick.ProductPerDay} eggs per day.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
