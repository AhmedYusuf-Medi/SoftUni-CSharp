using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                .Split()
                                .Select(int.Parse)
                                .ToList();

            int middle = numbers.Count / 2;

            double leftCar = FindFirstCarFinishTime(numbers, middle);
            double rightCar = FindSecondCarFinishTime(numbers, middle);

            if (leftCar < rightCar)
            {
                Console.WriteLine($"The winner is left with total time: {leftCar}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {rightCar}");
            }
           
        }

        private static double FindSecondCarFinishTime(List<int> numbers, int middle)
        {
            double car = 0;

            for (int i = numbers.Count - 1; i > middle; i--)
            {
                int curretTime = numbers[i];
                car += curretTime;
                if (curretTime == 0)
                {
                    car *= 0.8;
                }
            }

            return car;
        }

        private static double FindFirstCarFinishTime(List<int> numbers, int middle)
        {
            double car = 0;
            for (int i = 0; i < middle; i++)
            {
                int currentTime = numbers[i];
                car += currentTime;
                if (currentTime == 0)
                {
                    car *= 0.8;
                }
            }

            return car;
        }
    }
}
