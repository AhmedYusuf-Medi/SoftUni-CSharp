using System;
using System.Collections.Generic;

namespace WildFarm
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string line;

            while ((line = Console.ReadLine()) != "End")
            {
                string[] animalArg = line.Split();
                Animal animal = CreateAnimal(animals, animalArg);

                string[] foodArg = Console.ReadLine().Split();
                Food food = CreateFood(foodArg);

                animal.ProduceSound();
                animal.Eat(food);
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        private static Food CreateFood(string[] foodArg)
        {
            string foodName = foodArg[0];
            int quantity = int.Parse(foodArg[1]);

            Food food = null;
            if (foodName == nameof(Vegetable))
            {
                food = new Vegetable(quantity);
            }
            else if (foodName == nameof(Fruit))
            {
                food = new Fruit(quantity);
            }
            else if (foodName == nameof(Meat))
            {
                food = new Meat(quantity);
            }
            else if (foodName == nameof(Seeds))
            {
                food = new Seeds(quantity);
            }
            return food;
        }

        private static Animal CreateAnimal(List<Animal> animals, string[] arg)
        {
            string animalType = arg[0];
            string name = arg[1];

            Animal animal = null;

            if (animalType == nameof(Owl))
            {
                double weight = double.Parse(arg[2]);
                double wingSize = double.Parse(arg[3]);
                Animal owl = new Owl(name, weight, wingSize);
                animal = owl;
                animals.Add(owl);
            }
            else if (animalType == nameof(Hen))
            {
                double weight = double.Parse(arg[2]);
                double wingSize = double.Parse(arg[3]);
                Animal hen = new Hen(name, weight, wingSize);
                animal = hen;
                animals.Add(hen);
            }
            else if (animalType == nameof(Cat))
            {
                double weight = double.Parse(arg[2]);
                string region = arg[3];
                string breed = arg[4];
                Animal cat = new Cat(name, weight, region, breed);
                animal = cat;
                animals.Add(cat);
            }
            else if (animalType == nameof(Tiger))
            {
                double weight = double.Parse(arg[2]);
                string region = arg[3];
                string breed = arg[4];
                Animal tiger = new Tiger(name, weight, region, breed);
                animals.Add(tiger);
                animal = tiger;
            }
            else if (animalType == nameof(Dog))
            {
                double weight = double.Parse(arg[2]);
                string region = arg[3];
                Animal dog = new Dog(name, weight, region);
                animals.Add(dog);
                animal = dog;
            }
            else if (animalType == nameof(Mouse))
            {
                double weight = double.Parse(arg[2]);
                string region = arg[3];
                Animal mouse = new Mouse(name, weight, region);
                animals.Add(mouse);
                animal = mouse;
            }

            return animal;
        }
    }
}
