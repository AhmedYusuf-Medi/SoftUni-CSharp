using System;

namespace _01.DataTypeFinder
{
    class Program
    {
        private const string isInteger = " is integer type";
        private const string isFloat = " is floating point type";
        private const string isBolean = " is boolean type";
        private const string isString = " is string type";
        private const string isChar = " is character type";
        static void Main(string[] args)
        {
            string type = String.Empty;
            char charType;
            float floatingNumber;
            int integerNumber;
            bool boolType;

            while (true)
            {
                type = Console.ReadLine();

                if (type.ToLower() == "end")
                {
                    break;
                }
                else if (int.TryParse(type, out integerNumber))
                {
                    Console.WriteLine($"{type}{isInteger}");
                }
                else if (float.TryParse(type, out floatingNumber))
                {
                    Console.WriteLine($"{type}{isFloat}");
                }
                else if (char.TryParse(type, out charType))
                {
                    Console.WriteLine($"{type}{isChar}");
                }
                else if (bool.TryParse(type, out boolType))
                {
                    Console.WriteLine($"{type}{isBolean}");
                }
                else
                {
                    Console.WriteLine($"{type}{isString}");
                }
            }
        }
    }
}
