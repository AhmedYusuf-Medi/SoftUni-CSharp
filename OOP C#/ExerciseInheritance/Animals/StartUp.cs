using System;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input;

            while ((input = Console.ReadLine()) != "Beast!")
            {
                string[] arg = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = arg[0];
                int age = int.Parse(arg[1]);
                string gender = arg[2];


                if (name == null || age < 0 ||gender == null)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                switch (input)
                {
                    case "Dog":
                        Dog dog = new Dog(name, age, gender);
                        Console.WriteLine(dog);
                        Console.WriteLine(dog.ProduceSound());
                        break;
                    case "Cat":
                        Cat cat = new Cat(name, age, gender);
                        Console.WriteLine(cat);
                        Console.WriteLine(cat.ProduceSound());
                        break;
                    case "Frog":
                        Frog frog = new Frog(name, age, gender);
                        Console.WriteLine(frog);
                        Console.WriteLine(frog.ProduceSound());
                        break;
                    case "Kitten":
                        Kitten kitten = new Kitten(name, age);
                        Console.WriteLine(kitten);
                        Console.WriteLine(kitten.ProduceSound());
                        break;
                    case "Tomcat":
                        Tomcat tom = new Tomcat(name, age);
                        Console.WriteLine(tom);
                        Console.WriteLine(tom.ProduceSound());
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
