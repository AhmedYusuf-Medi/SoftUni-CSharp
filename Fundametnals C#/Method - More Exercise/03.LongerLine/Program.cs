using System;

namespace _03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //first cordinates 2D
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            //second cordinates 2D
            double a1 = double.Parse(Console.ReadLine());
            double b1 = double.Parse(Console.ReadLine());
            double a2 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            //Calculate distance beetwen pooints
            double firstInput = DistanceBeetwenPoints(x1, y1, x2, y1);
            double secondInput = DistanceBeetwenPoints(a1, b1, a2, b2);
            //Check wich one is closer to Zero
            bool closestToZeroFirst = ClosestToZeroFirst(x1,y1,x2,y2);
            bool closestToZeroSecond = ClosestToZeroFirst(a1,b1,a2,b2);

            if (firstInput >= secondInput)
            {
                if (closestToZeroFirst)
                {
                    //print like the input
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                }
                else
                {
                    //print backward the input
                    Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
                }
            }
            else
            {
                if (closestToZeroSecond)
                {
                    Console.WriteLine($"({a1}, {b1})({a2}, {b2})");
                }
                else
                {
                    Console.WriteLine($"({a2}, {b2})({a1}, {b1})");
                }
            }


        }

        private static double DistanceBeetwenPoints(double x1, double y1, double x2, double y2)
        {
            double sideA = Math.Abs(x2 - x1);
            double sideB = Math.Abs(y2 - y1);

            double sideC = Math.Sqrt(Math.Pow(sideA ,2)) + (Math.Pow(sideB,2));

            return sideC;
        }
        private static double GetHypotenuse(double a, double b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            double c = Math.Sqrt((Math.Pow(a,2)) + (Math.Pow(b,2)));
            return c;
        }
        private static bool ClosestToZeroFirst(double x1, double y1, double x2, double y2)
        {
            double c1 = GetHypotenuse(x1, y1);
            double c2 = GetHypotenuse(x2, y2);

            bool result = true;

            if (c2 < c1)
            {
                result = false;
            }

            return result;
        }

    }
}
