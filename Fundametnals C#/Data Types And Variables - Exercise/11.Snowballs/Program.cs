using System;
using System.Numerics;

namespace _11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            BigInteger bestSnowballValue =  0;

            string output = String.Empty;

            for (int i = 0; i < n; i++)
            {

                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime),snowballQuality);

                if (snowballValue >= bestSnowballValue)
                {
                    output = $"{snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})";
                    bestSnowballValue = snowballValue;
                }
            }

            Console.WriteLine(output);
        }
    }
}
