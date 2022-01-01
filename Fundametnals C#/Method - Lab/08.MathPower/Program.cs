using System;

namespace _08.MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double result = Power(a, b); ;
            Console.WriteLine(result);
        }
        static double Power(double number, double power)
        {
            double result = Math.Pow(number, power); ;
            return result;
        }
    }
}
