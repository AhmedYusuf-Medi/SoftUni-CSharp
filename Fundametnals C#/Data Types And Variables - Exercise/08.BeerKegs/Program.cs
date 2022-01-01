using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            //: π * r^2 * h. 
            int n = int.Parse(Console.ReadLine());
            string biggestKeg = string.Empty;
            double biggestVol = 0;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());

                double volume = Math.PI * Math.Pow(radius, 2) * h;

                if (volume > biggestVol)
                {
                    biggestVol = volume;
                    biggestKeg = model;
                }

            }
            Console.WriteLine(biggestKeg);
        }
    }
}
