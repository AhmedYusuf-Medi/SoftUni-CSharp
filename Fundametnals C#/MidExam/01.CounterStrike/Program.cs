using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());
            int battles = 0;
            int wins = 0;
            bool isWiner = true;

            string input = Console.ReadLine();
            while (input != "End of battle")
            {
                battles++;

                int distance = int.Parse(input);
                
                if (energy < distance)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
                    isWiner = false;
                    break;

                }

                wins++;
                energy -= distance;
                if (wins % 3 == 0)
                {
                    energy += wins;

                }
                input = Console.ReadLine();
            }
            if (isWiner)
            {
                Console.WriteLine($"Won battles: {battles}. Energy left: {energy}");
            }       
        }
    }
}
