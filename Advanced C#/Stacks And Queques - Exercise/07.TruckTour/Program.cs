using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<int[]> circle = new Queue<int[]>();

            for (int entry = 0; entry < n; entry++)
            {
                circle.Enqueue(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            }


            for (int entry = 0; entry < n; entry++)
            {
                if (IsSolution(n, circle))
                {
                    Console.WriteLine(entry);
                    break;
                }
                int[] startingPump = circle.Dequeue();
                circle.Enqueue(startingPump);
            }
        }

        static bool IsSolution(int n, Queue<int[]> circle)
        {
            int tankFuel = 0;
            bool foundAnswer = true;

            for (int entry = 0; entry < n; entry++)
            {
                int[] currPump = circle.Dequeue();
                tankFuel += currPump[0] - currPump[1];
                if (tankFuel < 0)
                {
                    foundAnswer = false;
                }
                circle.Enqueue(currPump);
            }

            if (foundAnswer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
