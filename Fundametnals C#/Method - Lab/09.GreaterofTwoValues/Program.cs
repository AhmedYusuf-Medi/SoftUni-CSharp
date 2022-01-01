using System;

namespace _09.GreaterofTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int sec = int.Parse(Console.ReadLine());
                    int output = GetMax(first, sec);
                    Console.WriteLine(output);
                    break;
                case "string":
                    string firstS = Console.ReadLine();
                    string secondS = Console.ReadLine();
                    string outputS = GetMax(firstS, secondS);
                    Console.WriteLine(outputS);
                    break;
                case "char":
                    char firstC = char.Parse(Console.ReadLine());
                    char secondC = char.Parse(Console.ReadLine());
                    char ouputC = GetMax(firstC, secondC);
                    Console.WriteLine(ouputC);
                    break;
            }
        }
        static int GetMax(int first, int second)
        {
            int max = Math.Max(first, second);
            return max;
        }
        static string GetMax(string first, string second)
        {
            int comparison = first.CompareTo(second);
            if (comparison > 0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static char GetMax(char first, char second)
        {
            char max = (char)Math.Max(first, second);
            return max;
        }
    }
}
