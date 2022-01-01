using System;

namespace PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pizzaArg = Console.ReadLine().Split();
            var pizzaName = pizzaArg[1];

            string[] doughArg = Console.ReadLine().Split();
            var doughType = doughArg[1];
            var bakingTechnique = doughArg[2];
            var weight = int.Parse(doughArg[3]);
            try
            {
                Dough dough = new Dough(doughType, bakingTechnique, weight);

                Pizza pizza = new Pizza(pizzaName, dough);

                string line;
                while ((line = Console.ReadLine()) != "END")
                {
                    var arg = line.Split();

                    var toppingName = arg[1];
                    var toppingWeight = int.Parse(arg[2]);

                    Topping topping = new Topping(toppingName, toppingWeight);

                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizzaName} - {pizza.GetCalories():F2} Calories.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
