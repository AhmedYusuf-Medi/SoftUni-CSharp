using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int num = int.Parse(Console.ReadLine());
                IfDataTypeIsInt(num);
            }
            else if (input == "real")
            {
                double num = double.Parse(Console.ReadLine());
                IfDataTypeIsDouble(num);
            }
            else
            {
                string text = Console.ReadLine();
                IfDataTypeIsString(text);
            }
        }

        private static void IfDataTypeIsString(string text)
        {
            Console.WriteLine($"${text}$");
        }

        private static void IfDataTypeIsDouble(double num)
        {
            double result = num * 1.5;
            Console.WriteLine($"{result:f2}");
        }

        private static void IfDataTypeIsInt(int num)
        {
            Console.WriteLine(num * 2);
        }
    }
}
