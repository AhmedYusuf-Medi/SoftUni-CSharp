using System;
using System.Linq;
namespace _02.CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] cordinates = new double[4];
            for (int i = 0; i < cordinates.Length; i++)
            {
                cordinates[i] = int.Parse(Console.ReadLine());
            }

            ClosestPoint(cordinates[0],cordinates[1],cordinates[2],cordinates[3]);

        }

        static void ClosestPoint(double x1, double y1, double x2, double y2)
        {
            double first = Math.Sqrt(Math.Pow(y1, 2) + Math.Pow(x1, 2));
            double second = Math.Sqrt(Math.Pow(y2, 2) + Math.Pow(x2, 2));

            if (first <= second)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
