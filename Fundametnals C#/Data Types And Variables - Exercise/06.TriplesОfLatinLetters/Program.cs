using System;

namespace _06.TriplesОfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int first = 0; first < n; first++)
            {
                for (int second = 0; second < n; second++)
                {
                    for (int third = 0; third < n; third++)
                    {
                        char firstChar = (char)(97 + first);
                        char secondChar = (char)(97 + second);
                        char thirdChar = (char)(97 + third);

                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
