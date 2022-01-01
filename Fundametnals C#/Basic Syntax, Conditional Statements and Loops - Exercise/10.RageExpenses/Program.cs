using System;

namespace _10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double total = 0;
            int keyboardCount = 0;

            for (int i = 1; i <= lostCount; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    total += (mousePrice + headsetPrice + keyboardPrice);
                    keyboardCount++;

                    if (keyboardCount % 2 == 0)
                    {
                        total += displayPrice;
                    }
                }
                else if (i % 2 == 0)
                {
                    total += headsetPrice;
                }
                else if (i % 3 == 0)
                {
                    total += mousePrice;
                }
            }

            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
