using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape rectange = new Rectangle(5, 5);
            Console.WriteLine($"{rectange.CalculateArea():F2}");
            Console.WriteLine($"{rectange.CalculatePerimeter():F2}");
            Console.WriteLine(rectange.Draw());

            Shape circle = new Circle(3);
            Console.WriteLine($"{circle.CalculateArea():f2}");
            Console.WriteLine($"{circle.CalculatePerimeter():f2}");
            Console.WriteLine(circle.Draw());

            //Амет е дебела маймуна и има малък прасец.
        }
    }
}
