using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        const int flowersWeNeed = 15;
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse));
            Queue<int> roses = new Queue<int>(Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse));

            int wreaths = 0;

            int leftFlowers = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                int lilie = lilies.Pop();
                int rose = roses.Dequeue();

                int sum = lilie + rose;

                if (sum == flowersWeNeed)
                {
                    wreaths++;
                }
                else if (sum > flowersWeNeed)
                {
                    while (true)
                    {
                        if (sum == flowersWeNeed)
                        {
                            wreaths++;
                            break;
                        }
                        else if (sum < flowersWeNeed)
                        {
                            leftFlowers += sum;
                            break;
                        }
                        else
                        {
                            sum -= 2;
                        }
                    }
                }
                else
                {
                    leftFlowers += sum;
                }
            }

            while (leftFlowers >= 15)
            {

                if (leftFlowers>= flowersWeNeed)
                {
                    leftFlowers -= flowersWeNeed;
                    wreaths++;
                }
            }

            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5-wreaths} wreaths more!");
            }
        }
    }
}
