using System;

namespace _04.NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstEmploye = int.Parse(Console.ReadLine());
            int secEmploye = int.Parse(Console.ReadLine());
            int thirdEmploye = int.Parse(Console.ReadLine());

            int sum = firstEmploye + secEmploye + thirdEmploye;

            int questions = int.Parse(Console.ReadLine());

            int hours = 0;

            while (questions != 0)
            {
                if (questions > sum)
                {
                    questions -= sum;
                    hours++;
                }
                else
                {
                    questions = 0;
                    hours++;
                }
                if (hours % 4 == 0)
                {
                    hours++;
                }
            }
           
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
