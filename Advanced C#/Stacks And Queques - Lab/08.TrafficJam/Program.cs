using System;
using System.Collections.Generic;

namespace _07.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();

            int count = 0;

            string input = String.Empty;

            while ((input =  Console.ReadLine()) != "end")
            {
                if (input != "green")
                {
                    cars.Enqueue(input); 
                }
                else
                {
                    if (cars.Count > 0)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            if (cars.Count > 0)
                            {
                                Console.WriteLine(cars.Dequeue() + " passed!");
                                count++;
                            }  
                        }
                    }
                }
            }
            Console.WriteLine(count + " cars passed the crossroads.");
        }
    }
}
